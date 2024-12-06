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

            Uczen uczen1 = new Uczen();
            uczen1.UstawImie("Jan");
            uczen1.UstawNazwisko("Kowalski");
            uczen1.UstawPesel("12321234173");
            uczen1.UstawSzkole("Szkoła Podstawowa");
            uczen1.UstawCzyMozeSamWrocic(false);
            uczen1.PobierzInformacjeOEdukacji();
            uczen1.Informacja();
            Console.WriteLine();
            Uczen uczen2 = new Uczen();
            uczen2.UstawImie("Anna");
            uczen2.UstawNazwisko("Nowak");
            uczen2.UstawPesel("12242312345");
            uczen2.UstawSzkole("Szkoła Podstawowa");
            uczen2.UstawCzyMozeSamWrocic(true);
            uczen2.PobierzInformacjeOEdukacji();
            uczen2.Informacja();
            Console.WriteLine();
            Nauczyciel nauczyciel = new Nauczyciel();
            nauczyciel.UstawImie("Elżbieta");
            nauczyciel.UstawNazwisko("Król");
            nauczyciel.UstawPesel("88112354384");
            nauczyciel.TytulNaukowy = "Magister";
            Console.WriteLine(nauczyciel.PobierzPelneImieNazwisko());
            Console.WriteLine("Pesel: {0}", nauczyciel.Pesel);
            Console.WriteLine("Wiek: {0}", nauczyciel.PobierzWiek());
            Console.WriteLine();
            nauczyciel.DodajUcznia(uczen1);
            nauczyciel.DodajUcznia(uczen2);
            nauczyciel.PodsumowanieKlasy(DateTime.Now);
        }
    }
}
