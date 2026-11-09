
namespace RPGKarakterveSavasSistemi.Models;

public class Sifaci : Karakter
{
    private int iyilesmeGucu;
    public int IyilestirmeGucu { 
        get
        { return 2 * iyilesmeGucu; }
        set 
        { iyilesmeGucu = 2 * value; }
    } 
    public Sifaci(string isim, int can, int saldiriGucu, int iyilesmegucu) : base(isim, can, saldiriGucu)
    {
        iyilesmeGucu = iyilesmegucu;
    }

    public override void Iyiles(int miktar)
    {
        iyilesmeGucu = 2 * miktar;
        base.Iyiles(iyilesmeGucu);
    }

    public void Iyilestir(Karakter hedefKarakter)
    {
        hedefKarakter.Can += IyilestirmeGucu;       
    }

    public override void BilgiGoster()
    {
        Console.WriteLine($"Adı: {Isim}\nSağlık Puanı: {Can}\nSaldırı Gücü: {SaldiriGucu}\nİyileştirme Gücü:{IyilestirmeGucu}");
    }
}
