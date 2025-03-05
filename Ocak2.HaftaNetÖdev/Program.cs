// c# temel veri tipleri şunlardır : int, double, float, char, string, bool.
// x değeri int olduğundan bellek kullanımı 4 byte olacaktır.
//y değeri ise double olduğundan bellek kullanımı 8 byte olacaktır.
//name değeri string olduğundan harf başına bellek kullanımı 2 byte olacaktır. bu yüzden name değeri 6 harf olduğundan bellek kullanımı 12 byte olacaktır.
//kullanıcıdan 2 sayı alıp bu sayıların toplamını ekrana yazdıran program.
int x, y, sonuc;
Console.WriteLine("1. sayıyı giriniz:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz:");
y = Convert.ToInt32(Console.ReadLine());
sonuc = x + y;
Console.WriteLine("Sonuç: " + sonuc);
