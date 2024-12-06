using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Models
{
    internal class Uczen : Osoba
    {
        public string Szkola {  get; set; }
        public bool MozeSamWrocicDoDomu {  get; set; }

        public void UstawSzkole(string nazwa)
        {
            Szkola = nazwa;
        }
        public void ZmienSzkole(string nazwa)
        {
            Szkola = nazwa;
        }
        public void UstawCzyMozeSamWrocic(bool pom)
        {
            MozeSamWrocicDoDomu = pom;
        }
        public void Informacja()
        {
            if(CzyMozeSamWrocicDoDomu())
            {
                Console.WriteLine("Uczeń może wracać samodzielnie");
            }
            else
            {
                Console.WriteLine("Uczeń nie może wracać samodzielnie");
            }
        }
        public override void PobierzInformacjeOEdukacji()
        {
            Console.WriteLine("Imię: {0}\nNazwisko: {1}\nPesel:{2}\nWiek:{3}\nSzkoła:{4}", Imie, Nazwisko, Pesel, PobierzWiek(), Szkola);
        }
        public override bool CzyMozeSamWrocicDoDomu()
        {
            return PobierzWiek() >= 12 || MozeSamWrocicDoDomu;
        }
    }
}
