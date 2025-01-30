using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    internal class Square : Shape
    {
        public double a;
        public double b;

        public override double CalculateArea()
        {
            return a * b;
        }
    }
}
