using Easyware.Lib.ConsoleApp;

class BenimListem<MyType>
{
    private List<MyType> liste = new List<MyType>();
    public bool Ekle(MyType sayi, out int siraNumarasi)
    {
        if (liste.Contains(sayi))
        {
            siraNumarasi = -1;
            return false;
        }
        else
        {
            liste.Add(sayi);
            siraNumarasi = liste.Count;
            return true;
        }

    }
    public void Listele()
    {
        Ekran.BaslikYaz("Listem");
        foreach (MyType i in liste)
        {
            Console.WriteLine(i);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        BenimListem<int> sayiListe = new BenimListem<int>();
        BenimListem<string> isimListesi = new BenimListem<string>();
        int ndx;
        sayiListe.Ekle(10, out ndx);
        sayiListe.Ekle(20, out ndx);
        sayiListe.Listele();

        isimListesi.Ekle("Lizge", out ndx);
        isimListesi.Ekle("Şeyma", out ndx);
        isimListesi.Listele();

    }
}
