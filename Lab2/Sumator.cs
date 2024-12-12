using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Sumator
    {
        private int[] Liczby;

        public int Suma()
        {
            int suma = 0;
            foreach (int i in Liczby) suma += i;
            return suma;
        }
        public int SumaPodziel3()
        {
            int suma = 0;
            foreach (int i in Liczby)
            {
                if(i % 3 == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
        public int IleElementow()
        {
            return Liczby.Length;
        }
        public void Wypisz()
        {
            foreach (int i in Liczby)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void WypiszPomiedzy(int lowIndex, int highIndex)
        {
            for(int i = int.Max(lowIndex, 0); i <= int.Min(highIndex, Liczby.Length - 1); i++) Console.Write(Liczby[i] + " ");
            Console.WriteLine();
        }
        public Sumator(int[] l)
        {
            Liczby = l;
        }
    }
}
