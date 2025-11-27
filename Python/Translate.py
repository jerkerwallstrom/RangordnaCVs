
from deep_translator import GoogleTranslator

def trim_text(text, max_length=5000):
    if len(text) <= max_length:
        return text
    cut = text.rfind(" ", 0, max_length)
    if cut == -1:  # inga mellanslag hittades
        return text[:max_length]
    return text[:cut]


def translate_text(text, source_lang='en', target_lang='sv'):
    #translated = GoogleTranslator(source='en', target='sv').translate(text)

    max_length = 4980 #5000
    # Klipp texten om den är längre än max_length
    if len(text) > max_length:
        tmp1 = len(text)
        short_text = trim_text(text, max_length)
        tmp2 = len(short_text)
        translated = GoogleTranslator(source=source_lang, target=target_lang).translate(short_text)
        if (text[:100]) == (short_text[:100]):
            translated = text
    else:
        translated = GoogleTranslator(source=source_lang, target=target_lang).translate(text)
    #translator = GoogleTranslator(source=source_lang, target=target_lang)
    #translated = translator.translate(text)
    return translated

# Text att översätta
#text = "Hello, how are you today?"

#translated = translate_text(text, source_lang='en', target_lang='sv')   
#tmp = GoogleTranslator(source='auto', target='en').translate(translated)

# Översätt från engelska till svenska

#print(f"Original: {text}")
#print(f"Översatt: {translated}")
