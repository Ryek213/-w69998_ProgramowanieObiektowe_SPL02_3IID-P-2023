using Lab4.Models;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = [new Rectangle(1), new Triangle(1), new Circle(1)];

            foreach (var e in shapes)
            {
                e.Draw();
            }

            Console.WriteLine("\n\n");

            Osoba osoba = new Osoba();

            osoba.Imie = "A";
            Console.WriteLine(osoba.Imie);

            osoba.Nazwisko = "B";
            Console.WriteLine(osoba.Nazwisko);

            osoba.Pesel = "12321234123";
            Console.WriteLine(osoba.Pesel);

            Console.WriteLine(osoba.PobierzWiek());

            Console.WriteLine(osoba.PobierzPlec());
        }
    }
}
