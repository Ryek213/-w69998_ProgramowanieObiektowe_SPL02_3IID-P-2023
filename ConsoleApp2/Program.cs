namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz zadanie:");
                Console.WriteLine("1. Parzystość");
                Console.WriteLine("2. Liczby parzyste");
                Console.WriteLine("0. Wyjście");
                int zad = int.Parse(Console.ReadLine());

                switch (zad)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("Podaj liczbę");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            if (n % 2 == 0)
                            {
                                Console.WriteLine("Liczba jest parzysta");
                            }
                            else
                            {
                                Console.WriteLine("Liczba jest nieparzysta");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nie podano liczby");
                        }
                        break;
                }
            }
        }
    }
}
