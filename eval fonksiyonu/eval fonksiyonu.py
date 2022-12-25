# bizim yazdığımız herhangi bir kodu veya herhangi bir metni aynı python kodu gibi çalıştıran fonksiyondur.
hesaplama=input("""
HESAP MAKİNESİ

İŞLEÇLER

TOPLAMA=+
ÇIKARMA=-
ÇARPMA=*
BÖLME=/

YAPMAK İSTEDİĞİNİZ İŞLEMİ ŞU ŞEKİLDE GİRİNİZ : 31*31
""")
print(eval(hesaplama))