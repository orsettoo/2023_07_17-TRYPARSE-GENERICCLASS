using Easyware.Lib.ConsoleApp;

abstract class Sekil2B<T>
{
    public abstract T AlanHesapla();
    public abstract T CevreHesapla();
    public void Hakkinda()
    {
        Console.WriteLine("Alan = " + AlanHesapla() + ", Cevre=" + CevreHesapla());
    }
}

class Kare : Sekil2B<int>
{
    public int Kenar { get; set; }
    public override int AlanHesapla()
    {
        return Kenar * Kenar;
    }
    public override int CevreHesapla()
    {
        return 4 * Kenar;
    }
}
class Daire : Sekil2B<double>
{
    public double YariCap { get; set; }
    public double PI = 3.14;

    public override double AlanHesapla()
    {
        return PI * YariCap * YariCap;
    }
    public override double CevreHesapla()
    {
        return 2 * PI * YariCap;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ekran.BaslikYaz("Generic Class");
        Daire daire = new Daire() { YariCap = 5.3 };
        Kare kare = new Kare() { Kenar = 7 };

        daire.Hakkinda();
        kare.Hakkinda();  
    }
}
