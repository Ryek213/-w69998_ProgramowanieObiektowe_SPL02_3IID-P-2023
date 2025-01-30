using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    internal class Circle : Shape
    {
        public double r;
        public override double CalculateArea()
        {
            return Math.Pow(r, 2) * Math.PI;
        }
    }
}
