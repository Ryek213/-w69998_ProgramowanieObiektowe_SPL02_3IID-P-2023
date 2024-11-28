using Lab4.Models;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Rectangle(1));
            shapes.Add(new Triangle(1));
            shapes.Add(new Circle(1));

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

            osoba.Pesel = "12341234123";
            Console.WriteLine(osoba.Pesel);
        }
    }
}
