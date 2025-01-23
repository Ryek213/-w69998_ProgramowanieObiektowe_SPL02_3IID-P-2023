using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Triangle : Shape
    {
        public double a;
        public double h;

        public override double CalculateArea()
        {
            return a * h / 2;
        }
    }
}
