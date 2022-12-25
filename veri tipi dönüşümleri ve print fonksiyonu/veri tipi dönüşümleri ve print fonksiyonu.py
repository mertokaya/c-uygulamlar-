a=31.78
print(int(a))
b=31
print(float(b))
#int() ve float() kullanımları 

a=45
print(str(a))
# str() kullanımı
a=str(a)
print(str(a*3))
b=31.31
print(str(b))
b=str(b)
print(str(b*5))
# integer ve float değerleri stringe çevirme

string="123456"
print(string)
string=int(string)
print(int(string))
# string değerlerin integer'a dönüşmesi
# string="123ab" string=int(string) print(int(string)) bu bir hatalı kullanımdır. Çünkü rakam olmayan şeyler(harfler özel imgeler vb.) var...

string="31.31"
print(string)
string=float(string)
print(float(string))
# string değerlerin float'a çevrilmesi

print("UMUT","KENDİNİ UNUT")
# string değerlerde sep parametresi otomatik olarak sisteme düşer. Ama bunu bizde ekleyebiliriz veya değiştirebiliriz.
print("UMUT","KENDİNİ UNUT",sep=" ")
print("UMUT","KENDİNİ UNUT",sep="*")
# printlerde sep parametresi

print(*"İSOBİRD")
# string değerleri tek bir string dosyası olarak düşündü ve yıldız parametresi hepsini ayırdı. printlerde (*) parametsi

print(*"İSOBİRD",sep="/")
# aralarını / bunu koyduk.