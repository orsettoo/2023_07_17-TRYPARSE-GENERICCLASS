using Easyware.Lib.ConsoleApp;

class BenimListem
{
    private List<int> liste = new List<int>();
    public bool Ekle(int sayi, out int siraNumarasi)
    {
        if (liste.Contains(sayi))
        {
            Console.WriteLine("sayı zaten var");
            siraNumarasi = -1;
            return false;
        }
        else
        {
            liste.Add(sayi);
            Console.WriteLine("Sayı eklendi");
            siraNumarasi = liste.Count;
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
        int siraNo = 0;
        if (liste.Ekle(20,out siraNo))
        {
            Console.WriteLine(20+" sayisi eklendi. sıra = "+siraNo);
        }

        if (liste.Ekle(25,out int Index)) // index sira no anlamına geliyor.
        {
            Console.WriteLine(25 + " sayisi eklendi. sıra = " + Index);
        }

        for (int i = 0; i <= 3; i++)

        {
            int sayi = Ekran.SayiOku("sayiyi giriniz =");
            if(liste.Ekle(sayi,out int sira))
            {
                Console.WriteLine($"{sayi} eklendi sıra = {sira }");
            }else
                Console.WriteLine($"{sayi} zaten var " );
        }


            



        Console.WriteLine();
        liste.Listele();
    }
}
