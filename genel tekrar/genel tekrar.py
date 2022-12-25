msg="hello"
print(msg)
# merhaba yazdırdım.

# sayısal ve matematik işlemleri

print(4) # int değerler tam sayı
print(4.55654) # float değerler ondalıklı sayılar
# print(a) bu hatalı bir kullanımdır...

print(10+3)
print(10*3)
print(10-3)
print(10/3)
# dört işlem

print(10+3*4) # işlem önceliği
print((10+3)*4) # işlem önceliği parçalandı dağıldı

# DEĞİŞKENLER

x=10
print(x)
devkod=31
print(devkod)
# değişkenlere değer verme

# 31devkod=312  hatalı bir kullanımdır. Değişken isimleri sayı ile başlamaz...
# x y=312 hatalı bir kullanımdır. Değişken isimleri arasında boşluk bırakılamaz...
# @devkod=31 hatalı bir kullanımdır. Değişken isimlerinde özel imgeler bulunamaz...
# print=31 print(print) hatalı bir kullanımdır. Anahtar kelimeler değişken ismi olarak kullanılamaz...

dev_kod=31
print(dev_kod)
# bu doğru bir kullanımdır.

yukseklik=12
taban=24    
ucgenAlan=yukseklik*taban/2
print(ucgenAlan)
# deeğişkenleri bir formül olarak kullanabilriz...

x=10
print(x)
x=x+1
print(x)
x+=1
print(x)
# değişkenlerin hızlı kullanılabilmesi için bir kısayol. (dört işlem için uygundur.)

x=19
y=9
print(x//y)
# sonucu tam sayı veren bölme operatörü //

x=9
y=12
z=31
print(x%2)
print(y%2)
print(z%6)
# tek çift bulma

print(9%5)
print(31%23)
# bölmede kalan bulma %

print(4**3)
print(4**(1/2))
# üs ve karekök bulma **

x=5
print(x)
print(-x)
y=-5
print(y)
print(-y)
# işaret değiştirme -

# STRİNG DEĞİŞKENİ

print("enes merhaba")
nesne="merhaba"
print(nesne)
# string bir değer oluşturma ve değişkenli bir değer oluşturma

print(nesne[0])
print(nesne[-1])
# string indeks kullanımı

print(nesne[0:3])
# başlangıç indeksi : son indeks(dahil değil)

print(nesne[0:3:2])
# başlangıç indeksini aldı son indeksi dahil etmeden aldık sonra bunu 2 2 arttırdık

print(nesne[::-1])
# stringimizi ters çevirdik...

print(len(nesne))
# len fonskiyonu stringimizde kaç değer olduğunu gösterir...

maviyona="cengaver"
print(nesne+" "+maviyona)
# stringlerin birbirleriyle toplanması

print(nesne*4)
# stringlerin çarpılması

