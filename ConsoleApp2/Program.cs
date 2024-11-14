namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Wybierz zadanie:");
                    Console.WriteLine("1. Parzystość liczby");
                    Console.WriteLine("2. Wypisz liczby parzyste");
                    Console.WriteLine("0. Wyjście");
                    Console.Write("> ");
                    int zad = int.Parse(Console.ReadLine());

                    if (zad == 0)
                    {
                        break;
                    }

                    Console.WriteLine();

                    switch (zad)
                    {
                        case 1:
                            {
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

                                Console.WriteLine();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Podaj koniec zakresu:");
                                int n = int.Parse(Console.ReadLine());
                                String result = "";
                                for (int i = 0; i <= n; i += 2)
                                {
                                    result += i.ToString() + " ";
                                }
                                Console.WriteLine(result);

                                Console.WriteLine();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine();
                                break;
                            }
                        default:
                            {
                                throw new ArgumentOutOfRangeException("zadanie");
                            }
                    }
                }
            }
            catch (FormatException e)
            { Console.WriteLine(e.Message); }
            catch (ArgumentNullException e)
            { Console.WriteLine(e.Message); }
            catch (ArgumentOutOfRangeException e)
            { Console.WriteLine(e.Message); }
        }
    }
}
