class Program
{
    static void Main(string[] args)
    {

        int sayi = 0;
        bool Basarili = false;
        do
        {
            Console.Write("Sayi girin = ");
            string GirilenSayi = Console.ReadLine();
            Basarili = int.TryParse(GirilenSayi, out sayi);
            if (!Basarili)
            {
                Console.WriteLine("yanlış giriş");
            }
        } while (!Basarili);
        Console.WriteLine("tebrikler " + sayi);






    }
}