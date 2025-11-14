import os
import re
from docx import Document
import pdfplumber
from sentence_transformers import SentenceTransformer, util

# ---- Läs CV-text ----
def read_pdf(file_path):
    text = ""
    with pdfplumber.open(file_path) as pdf:
        for page in pdf.pages:
            text += page.extract_text() + "\n"
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

# ---- AI-baserad matchning ----
def rank_cvs_semantic(folder_path, job_description):
    # Ladda modell (t.ex. all-MiniLM-L6-v2)
    model = SentenceTransformer('sentence-transformers/all-MiniLM-L6-v2')
    
    # Extrahera CV-text
    cv_texts = extract_cv_text(folder_path)
    
    # Skapa embedding för uppdragsbeskrivning
    job_embedding = model.encode(job_description, convert_to_tensor=True)
    
    # Beräkna likhet för varje CV
    scores = {}
    for filename, text in cv_texts.items():
        cv_embedding = model.encode(text, convert_to_tensor=True)
        similarity = util.cos_sim(job_embedding, cv_embedding).item()
        scores[filename] = similarity
    
    # Sortera efter högsta likhet
    ranked = sorted(scores.items(), key=lambda x: x[1], reverse=True)
    return ranked

# ---- Exempelanrop ----
if __name__ == "__main__":
    folder = "cv_mapp"  # Ange din mapp med CV:n
    job_desc = """Vi söker en senior Python-utvecklare med erfarenhet av molnlösningar och AI."""
    
    ranking = rank_cvs_semantic(folder, job_desc)
    print("Rangordning av CV:n (semantisk analys):")
    for filename, score in ranking:
        print(f"{filename}: {score:.4f}")