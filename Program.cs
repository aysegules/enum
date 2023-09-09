internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Gunler.Pazartesi);
        Console.WriteLine((int)Gunler.Cumartesi);//index numarasini getirir

        int sicaklik=27;

        if(sicaklik <= (int)HavaDurumu.Normal)
            Console.WriteLine("Disariya cikmak icin biraz daha havanin isinmasini bekleyelim.");
        else if(sicaklik >= (int)HavaDurumu.Sicak)
            Console.WriteLine("Disariya cikmak icin cok sicak bir gun.");
        else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik <(int)HavaDurumu.CokSicak)
            Console.WriteLine("Hadi disariya cikalim!");       
    }
}

enum Gunler
{
    Pazartesi = 1,
    Sali,
    Carsamba,
    Persembe,
    Cuma = 23,
    Cumartesi,
    Pazar
};

enum HavaDurumu
{
    Soguk = 5,

    Normal = 20,
    Sicak = 25,
    CokSicak = 30
}