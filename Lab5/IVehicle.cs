using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal interface IVehicle
    {
        int MaxSpeed { get; set; }

        void Start();

        void Stop();
    }
}
