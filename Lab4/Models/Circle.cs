﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab4.Models
{
    internal class Circle(double x) : Shape(x)
    {
        public override void Draw()
        {
            Console.WriteLine("Próbujesz narysować okrąg");
        }
    }
}
