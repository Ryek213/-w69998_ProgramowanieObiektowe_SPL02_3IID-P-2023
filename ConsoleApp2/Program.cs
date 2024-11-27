using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static int silnia(int n)
        {
            if (n > 1)
            {
                return n*silnia(n - 1);
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Wybierz zadanie:");
                    Console.WriteLine("1. Parzystość liczby");
                    Console.WriteLine("2. Wypisz liczby parzyste");
                    Console.WriteLine("3. Oblicz silnię");
                    Console.WriteLine("4. Zgadnij liczbę");
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
                                Console.WriteLine("Podaj liczbę:");
                                int n = int.Parse(Console.ReadLine());
                                if (n % 2 == 0)
                                {
                                    Console.WriteLine("Liczba jest parzysta");
                                }
                                else
                                {
                                    Console.WriteLine("Liczba jest nieparzysta");
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
                                Console.WriteLine("Podaj liczbę:");
                                int n = int.Parse(Console.ReadLine());
                                Console.WriteLine(silnia(n));

                                Console.WriteLine();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Podaj koniec zakresu:");
                                int n = int.Parse(Console.ReadLine());

                                Random random = new Random();
                                int wylosowanaLiczba = random.Next(n) + 1;
                                Console.WriteLine("Wylosowano liczbę!");
                                Console.WriteLine("Zgadnij liczbę z zakresu [1, {0}]", n);

                                int input;
                                int count = 1;
                                while (true)
                                {
                                    Console.Write("\n>");
                                    input = int.Parse(Console.ReadLine());

                                    if (input == wylosowanaLiczba)
                                    {
                                        Console.WriteLine("Zgadłeś/aś liczbę za {0} razem", count);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("To nie ta liczba! Próbuj dalej!");
                                        count++;
                                    }
                                }

                                Console.WriteLine();
                                break;
                            }
                        default:
                            {
                                throw new ArgumentOutOfRangeException();
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
