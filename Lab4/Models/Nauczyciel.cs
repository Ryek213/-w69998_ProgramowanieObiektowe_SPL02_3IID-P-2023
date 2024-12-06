using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    internal class Nauczyciel : Osoba
    {
        public string TytulNaukowy {  get; set; }
        public List<Uczen> UczniowieKlasy = new List<Uczen> { };

        public void DodajUcznia(Uczen uczen)
        {
            UczniowieKlasy.Add(uczen);
        }
        public void KtorzyUczniowieMogaWrocicSamodzielnie()
        {
            foreach(Uczen e in UczniowieKlasy)
            {
                if (e.CzyMozeSamWrocicDoDomu())
                {
                    Console.WriteLine(Imie, Nazwisko, PobierzPlec());
                }
            }
        }
        public void PodsumowanieKlasy(DateTime data)
        {
            Console.WriteLine("Dnia: {0}", data.ToLongDateString());
            Console.WriteLine("Nauczyciel: {0} {1} {2}", TytulNaukowy, Imie, Nazwisko);
            int i = 0;
            Console.WriteLine("Lista studentów:");
            foreach(Uczen e in UczniowieKlasy)
            {
                Console.WriteLine("{0}. {1} {2} {3}", i++, e.Imie, e.Nazwisko, e.PobierzPlec());
            }
        }
    }
}
