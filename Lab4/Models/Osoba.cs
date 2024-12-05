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

        public void UstawImie(string imie)
        {
            Imie = imie;
        }
        public void UstawNazwisko(string nazwisko)
        {
            Nazwisko = nazwisko;
        }
        public void UstawPesel(string pesel)
        {
            Pesel = pesel;
        }
        public int PobierzWiek()
        {
            DateTime czas = DateTime.Now;

            int pom = int.Parse(Pesel.Substring(2, 2));
            int miesiac = pom % 20;

            int stulecie = 0;
            switch (pom - miesiac)
            {
                case 0:
                    stulecie = 1900;
                    break;
                case 20:
                    stulecie = 2000;
                    break;
                case 40:
                    stulecie = 2100;
                    break;
                case 60:
                    stulecie = 2200;
                    break;
                case 80:
                    stulecie = 1800;
                    break;
            }

            DateTime urodziny = new DateTime(stulecie + int.Parse(Pesel.Substring(0, 2)), miesiac, int.Parse(Pesel.Substring(4, 2)));

            int wiek = czas.Year - urodziny.Year;
            if (urodziny > czas.AddYears(-wiek)) --wiek;

            return wiek;
        }
        public string PobierzPlec()
        {
            if (int.Parse(Pesel.Substring(9, 1)) % 2 == 0)
            {
                return "Kobieta";
            }
            else
            {
                return "Mężczyzna";
            }
        }
        public virtual void PobierzInformacjeOEdukacji() { }
        public virtual void PobierzPelneImieNazwisko() { }
        public virtual void CzyMozeSamWrocicDoDomu() { }
    }
}
