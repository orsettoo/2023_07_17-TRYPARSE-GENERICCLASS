class Program
{
    static void Main(string[] args)
    {
        string str = "MS .Net CSharp";
        string word = "Asp.Net";
        int sayi = 123;

        Console.WriteLine(str);
        Console.WriteLine(str.ToLower());
        Console.WriteLine(str.ToUpper());
        CizgiCiz();
        Console.WriteLine(str.Substring(3));
        Console.WriteLine(str.Substring(3, 4));
        Console.WriteLine(str.Substring(3, 4).ToUpper());
        CizgiCiz();
        Console.WriteLine(str.Length);
        Console.WriteLine($". karakteri string içinde {str.IndexOf(".")}. olarak yeralır");
        Console.WriteLine(str.IndexOf("X"));

        Console.WriteLine(str.PadLeft(20));
        Console.WriteLine(word.PadLeft(20));
        CizgiCiz();
        Console.WriteLine(sayi.ToString().PadLeft(5) + "|" + str.PadLeft(20));
        Console.WriteLine(sayi.ToString().PadLeft(5) + "|" + word.PadLeft(20));
        CizgiCiz();
        Console.WriteLine(str);
        Console.WriteLine(str.Replace(".Net", ".Net Core"));
        Console.WriteLine(str.Replace(".Net", ".Net Core").Replace("MS", "Microsoft"));
        Console.WriteLine(str.Replace(" ", "_"));
        CizgiCiz();
        Console.WriteLine(str.IndexOf("CS"));
        Console.WriteLine(str.Insert(8, "Languge "));

        str = "             ASP.Net       ";
        Console.WriteLine(str + "----");
        Console.WriteLine(str.TrimStart() + "----");
        Console.WriteLine(str.TrimEnd() + "----");
        Console.WriteLine(str.Trim() + "----");


    }

    private static void CizgiCiz()
    {
        Console.WriteLine("--------------");
    }
}
// learnmicrosoft.com bak!