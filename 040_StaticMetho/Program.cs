class Ekran
{
    public static  void CizgiCiz()
    {
        Console.WriteLine("----------------------");
    }
    public static void BaslikYaz(string baslik)
    {
        CizgiCiz();
        Console.WriteLine(baslik);
        CizgiCiz();
    }

}
class Daire
{
    public double YariCap { get; set; }
    public static  double PI = 3.14;
    public double AlanHesapla()
    {
        return PI * YariCap * YariCap;
    }

}
class Program
{
    static void Main(string[] args)
    {
        Ekran.BaslikYaz("Başlık");

        Daire daire = new Daire();
        daire.YariCap = 10.5;
        Console.WriteLine(daire.AlanHesapla());

        Console.WriteLine(Daire.PI);
    }
}

// static üyeler static üyeleri çağırabilir.