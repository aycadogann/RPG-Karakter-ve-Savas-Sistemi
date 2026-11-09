using RPGKarakterveSavasSistemi.Models;

Karakter karakter1 = new Karakter("Aras", 100, 15);
Karakter karakter2 = new Karakter("Elif", 20, 30);
Savasci savasci = new Savasci("Mert", 100, 10);
Sifaci sifaci = new Sifaci("Aslı", 5, 20,7);

karakter1.BilgiGoster();
Console.WriteLine(new string('-', 20));
karakter2.BilgiGoster();
Console.WriteLine(new string('-', 20));
savasci.BilgiGoster();
Console.WriteLine(new string('-', 20));
sifaci.BilgiGoster();
Console.WriteLine(new string('-', 20));



Console.WriteLine($"\n{karakter1.Isim}, {karakter2.Isim} saldırdı!");
karakter1.Saldir(karakter2);
Console.WriteLine($"{karakter2.Isim} {karakter1.SaldiriGucu} hasar aldı.");
Console.WriteLine($"{karakter2.Isim} kalan canı : {karakter2.Can}");
karakter2.HayattaMi();

Console.WriteLine($"\n{sifaci.Isim} {karakter2.Isim} iyileştirmeye çalışıyor...");
sifaci.Iyilestir(karakter2);
Console.WriteLine($"{karakter2.Isim} iyileşti. Son durum : {karakter2.Can} canı var.");

Console.WriteLine($"\n{sifaci.Isim} kendini iyileştirmeye çalışıyor...");
sifaci.Iyiles(12);
Console.WriteLine($"{sifaci.Isim} iyileşti. Son durum : {sifaci.Can} canı var.");

Console.WriteLine($"\n{savasci.Isim} yeni saldırı yaptı");
savasci.OzelSaldiri(karakter2);
Console.WriteLine($"{karakter2.Isim} {savasci.savasciSaldiriGucu} hasar aldı.");
Console.WriteLine($"{karakter2.Isim} kalan canı : {karakter2.Can}");
karakter2.HayattaMi();


Console.ReadKey();
