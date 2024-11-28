using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    internal class Osoba
    {
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        private string pesel;
        public string Pesel
        {
            get { return pesel; }

            set
            {
                if (value.Length == 11)
                {
                    foreach (char c in value)
                    {
                        if ( c < '0' || c > '9')
                        {
                            return;
                        }
                    }
                    pesel = value;
                }
            }
        }

        public void ustawImie(string imie)
        {
            Imie = imie;
        }
        public void ustawNazwisko(string nazwisko)
        {
            Nazwisko = nazwisko;
        }
        public void ustawPesel(string pesel)
        {
            Pesel = pesel;
        }
        public int pobierzWiek()
        {
            return Pesel.Substring
        }
    }
}
