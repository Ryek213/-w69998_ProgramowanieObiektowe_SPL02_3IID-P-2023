using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int wiek;
        public int Wiek
        {
            get
            {
                return wiek;
            }
            set
            {
                wiek = value < 0 ? 0 : value;
            }
        }
        public string Pesel { get; }

        public Osoba(string imie, string nazwisko, int wiek, string pesel)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Pesel = pesel;
        }
        public string PrzedstawSie()
        {
            return string.Format("Nazywam się {0} {1} i mam {2} lat", Imie, Nazwisko, Wiek);
        }
    }
}
