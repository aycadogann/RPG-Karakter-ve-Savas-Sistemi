namespace RPGKarakterveSavasSistemi.Models;

public class Savasci : Karakter
{
    public int savasciSaldiriGucu;
    public Savasci(string isim, int can, int saldiriGucu) : base(isim, can, saldiriGucu)
    {
    }

    public void OzelSaldiri(Karakter hedef)
    {
        savasciSaldiriGucu = 2 * SaldiriGucu;
        hedef.HasarAl(savasciSaldiriGucu);
    }
}
