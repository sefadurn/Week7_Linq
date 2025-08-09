/*
 Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.
*/

// CİFT OLAN SAYİLARI YAZDIR

Random random = new Random();  // RASTGELE -30 İLE 50 ARASINDA SAYİ ÜRETMEK İÇİN BİR RANDOM SINIFI OLUŞTURDUK.
List<int> numbers = new List<int>(); // TAM SAYİLARİ TUTACAK BOŞ BİR LİSTE OLUŞTURULDU.

for (int i = 0; i < 10; i++)
{
    int rastgeleSayi = random.Next(-30,50);
    numbers.Add(rastgeleSayi);
}

var CiftSayilar = numbers.Where(x => x % 2 == 0);  // WHERE KOMUTU İLE FİLTRELEME YAPARAK OLUŞTURDUĞUMUZ LİSTEDEKİ SAYİLARIN MODUNU ALDIK VE ÇİFT OLANLARI FOREACH İLE ALT ALTA YAZDIRDIK. 
foreach (var sayi in CiftSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-------------------------------------");

// TEK OLAN SAYİLARİ YAZDIR

var TekSayilar = numbers.Where(x => x % 2 == 1);  // WHERE KOMUTU İLE FİLTRELEME YAPARAK OLUŞTURDUĞUMUZ LİSTEDEKİ SAYİLARIN MODUNU ALDIK VE TEK OLANLARI FOREACH İLE ALT ALTA YAZDIRDIK. 
foreach (var sayi in TekSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("---------------------------------------");

// NEGATİF SAYİLARİ YAZDİR

var NegatifSayilar = numbers.Where(x => x < 0);  // NEGATİF OLANLARI WHERE İLE BULDUK.
foreach (var sayi in NegatifSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("------------------------------------------");

// POZİTİF SAYİLARİ YAZDİR

var PozitifSayilar = numbers.Where(x => x > 0);  // POZİTİF OLANLARI WHERE İLE BULDUK.
foreach (var sayi in PozitifSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("------------------------------------------");

// 15'TEN BÜYÜK VE 22'DEN KÜCÜK SAYİLAR

var yListe = numbers.Where(x => x > 15 && x<22);
foreach (var sayi in yListe)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("------------------------------------------");

// LİSTEDEKİ HER BİR SAYİNİN KARESİ

var KareAl = numbers.Select(x => x*x);  // BURADA ELEMANI SEÇİP ÜZERİNDE DEĞİŞİKLİK YAPACAĞIMIZ İÇİN WHERE YERİNE SELECT KOMUTUNU KULLANDIK.
foreach(var sayi in  KareAl)
{
    Console.WriteLine(sayi);
}