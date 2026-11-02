namespace RPGKarakterveSavasSistemi.Models;

public class Karakter
{
    public string Isim { get; set; }
    public int Can { get; set; }
    public int SaldiriGucu { get; set; }

    public Karakter(string isim, int can, int saldiriGucu)
    {
        Isim = isim;
        Can = can;
        SaldiriGucu = saldiriGucu;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Adı: {Isim}\nSağlık Puanı: {Can}\nSaldırı Gücü: {SaldiriGucu}");
    }

    public void HasarAl(int miktar)
    {
        Can -= miktar;
        if (Can < 0)
            Can = 0; //Console.WriteLine("Öldü!");
    }

    public virtual void Iyiles(int miktar)
    {

        Can += miktar;
        if (Can > 100)
            Can = 100;

        Console.WriteLine($"Yeni Can: {Can}");
    }

    public bool HayattaMi()
    {
        if (Can > 0)
            return true;
        else
            return false;
    }

    public void Saldir(Karakter hedef)
    {
        hedef.HasarAl(SaldiriGucu);
    }
}
