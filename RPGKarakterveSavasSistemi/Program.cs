using RPGKarakterveSavasSistemi.Models;

Karakter karakter1 = new Karakter("Aras", 100, 15);
Karakter karakter2 = new Karakter("Elif", 90, 30);
Savasci savasci = new Savasci("Aras", 100, 15);

karakter1.BilgiGoster();
Console.WriteLine(new string('-', 20));
karakter2.BilgiGoster();
Console.WriteLine(new string('-', 20));


Console.WriteLine($"\n{karakter1.Isim}, {karakter2.Isim} saldırdı!");
karakter1.Saldir(karakter2);
Console.WriteLine($"{karakter2.Isim} {karakter1.SaldiriGucu} hasar aldı.");
Console.WriteLine($"{karakter2.Isim} kalan canı : {karakter2.Can}");



Console.WriteLine($"\n{karakter2.Isim} kendini iyileştirmeye çalışıyor...");
karakter2.Iyiles(karakter2.SaldiriGucu);


Console.WriteLine($"\n{savasci.Isim} yeni saldırı yaptı");
savasci.OzelSaldiri(karakter2);
Console.WriteLine($"{karakter2.Isim} {savasci.savasciSaldiriGucu} hasar aldı.");
Console.WriteLine($"{karakter2.Isim} kalan canı : {karakter2.Can}");


Console.ReadKey();

