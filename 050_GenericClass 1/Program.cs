using Easyware.Lib.ConsoleApp;

class BenimListem
{
    private List<int> liste = new List<int>();
    public bool Ekle(int sayi)
    {
        if (liste.Contains(sayi))
        {
            Console.WriteLine("sayı zaten var");
            return false;
        }
        else
        {
            liste.Add(sayi);
            Console.WriteLine("Sayı eklendi");
            return true;
        }

    }
    public void Listele()
    {
        Ekran.BaslikYaz("Listem");
        foreach (int i in liste)
        {
            Console.WriteLine(i);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        BenimListem liste = new BenimListem();
        if (liste.Ekle(1))
        {
            // sayı eklendi
        }
        liste.Ekle(23);
        liste.Ekle(89);
        liste.Ekle(23);
        Console.WriteLine();
        liste.Listele();
    }
}
