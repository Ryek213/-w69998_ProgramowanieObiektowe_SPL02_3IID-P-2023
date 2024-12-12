namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba os = new Osoba("Jan", "Nowak", 34, "90111574636");
            Console.WriteLine(os.PrzedstawSie());
            Console.WriteLine(os.Pesel);

            Console.WriteLine();

            Licz li = new Licz(7);
            li.Wypisz();
            li.Dodaj(8);
            li.Wypisz();
            li.Odejmij(9);
            li.Wypisz();

            Console.WriteLine();

            Sumator su = new Sumator([5, 6, 1, 2, 4, 8, 5]);

            Console.WriteLine("Liczba elementów: {0}", su.IleElementow());
            su.Wypisz();
            su.WypiszPomiedzy(-3, 8);
            su.WypiszPomiedzy(1, 5);
            Console.WriteLine(su.Suma());
            Console.WriteLine(su.SumaPodziel3());
        }
    }
}
