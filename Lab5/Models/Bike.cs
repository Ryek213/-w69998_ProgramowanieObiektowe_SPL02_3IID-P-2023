using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Interfaces;

namespace Lab5.Models
{
    internal class Bike : IVehicle
    {
        public int MaxSpeed { get; set; }
        int numberOfSeats;
        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }
            set
            {
                if (value > 0)
                {
                    numberOfSeats = value;
                }
            }
        }

        public Bike(int maxSpeed, int numberOfSeats)
        {
            MaxSpeed = maxSpeed;
            NumberOfSeats = numberOfSeats;
        }

        public void Start()
        {
            Console.WriteLine("Rower zaczął jechać!");
        }

        public void Stop()
        {
            Console.WriteLine("Rower zatrzymał się!");
        }
    }
}
