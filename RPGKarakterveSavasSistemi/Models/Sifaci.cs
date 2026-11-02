namespace RPGKarakterveSavasSistemi.Models;

public class Sifaci : Karakter
{
    public int iyileşmeGucu;
    public Sifaci(string isim, int can, int saldiriGucu) : base(isim, can, saldiriGucu)
    {
    }

    public override void Iyiles(int miktar)
    {
        iyileşmeGucu = 2 * miktar;
        base.Iyiles(iyileşmeGucu);
    }
}
