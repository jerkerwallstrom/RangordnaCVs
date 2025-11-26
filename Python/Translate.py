
from deep_translator import GoogleTranslator

def translate_text(text, source_lang='en', target_lang='sv'):
    #translated = GoogleTranslator(source='en', target='sv').translate(text)
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
