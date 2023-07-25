public class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
}

public static class KisiExtentions
{
    public static string ToTamAdi(this Kisi kisi)
    {
        return kisi.Adi + " " + kisi.Soyadi.ToUpper();
    }
    public static string ToCapitize(this String yazi)
    {
        var ilkharf = yazi[0].ToString().ToUpper();
        return ilkharf + yazi.Substring(1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi() { Adi = "özge", Soyadi = "doblan" };
        Console.WriteLine(kisi.ToTamAdi());
        string str = "CSHARP";
        Console.WriteLine(str.ToCapitize()); //ilk harfi büyük olacak.
    }
}
