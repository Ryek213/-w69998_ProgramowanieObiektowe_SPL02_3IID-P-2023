using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Interfaces;

namespace Lab5.Models
{
    internal class Car : IVehicle
    {
        public int MaxSpeed { get; set; }
        public double FuelLevel { get; set; }

        public Car(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine("Samochód zaczął jechać!");
        }

        public void Stop()
        {
            Console.WriteLine("Samochód zatrzymał się!");
        }

        public double GetFuelLevel()
        {
            return FuelLevel;
        }
    }
}
