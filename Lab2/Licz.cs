using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Licz
    {
        private int wartosc;

        public void Dodaj(int n)
        {
            wartosc += n;
        }
        public void Odejmij(int n)
        {
            wartosc -= n;
        }

        public Licz(int wartosc)
        {
            this.wartosc = wartosc;
        }
        public void Wypisz()
        {
            Console.WriteLine(wartosc);
        }
    }
}
