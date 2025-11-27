import os
from docx import Document
import pdfplumber
from sentence_transformers import SentenceTransformer, util
from Translate import translate_text

# ---- Läs CV-text ----
def read_pdf(file_path):
    text = ""
    with pdfplumber.open(file_path) as pdf:
        for page in pdf.pages:
            page_text = page.extract_text()
            if page_text:
                text += page_text + "\n"
    return text

def read_docx(file_path):
    doc = Document(file_path)
    return "\n".join([para.text for para in doc.paragraphs])

def extract_cv_text(folder_path):
    cv_texts = {}
    for filename in os.listdir(folder_path):
        file_path = os.path.join(folder_path, filename)
        if filename.lower().endswith(".pdf"):
            cv_texts[filename] = read_pdf(file_path)
        elif filename.lower().endswith(".docx"):
            cv_texts[filename] = read_docx(file_path)
    return cv_texts

# ---- Beräkna keyword-score ----
def keyword_score(text, keywords):
    text_lower = text.lower()
    score = 0
    for word, weight in keywords.items():
        if word.lower() in text_lower:
            score += weight
    return score

# ---- AI-baserad matchning med viktade nyckelord ----
def rank_cvs_semantic_weighted(folder_path, job_description, weighted_keywords, translateDoc, source_lang='auto', target_lang='sv', alpha=0.7, beta=0.3):
    # Ladda modell
    model = SentenceTransformer('sentence-transformers/all-MiniLM-L6-v2')
    
    # Extrahera CV-text
    cv_texts = extract_cv_text(folder_path)
    
    # Skapa embedding för uppdragsbeskrivning
    job_embedding = model.encode(job_description, convert_to_tensor=True)
    
    # Beräkna likhet + keyword-score för varje CV
    scores = {}
    for filename, text in cv_texts.items():
        if text.strip():
            if translateDoc:
                text = translate_text(text, source_lang, target_lang)
            cv_embedding = model.encode(text, convert_to_tensor=True)
            similarity = util.cos_sim(job_embedding, cv_embedding).item()
            kw_score = keyword_score(text, weighted_keywords)
            final_score = alpha * similarity + beta * kw_score
            scores[filename] = final_score
        else:
            scores[filename] = 0.0
    
    # Sortera efter högsta score
    ranked = sorted(scores.items(), key=lambda x: x[1], reverse=True)
    return ranked