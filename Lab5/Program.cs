using Lab5.Models;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.r = 5;
            Console.WriteLine(circle.CalculateArea());

            Square square = new Square();
            square.a = 4;
            square.b = 5;
            Console.WriteLine(square.CalculateArea());

            Triangle triangle = new Triangle();
            triangle.a = 4;
            triangle.h = 5;
            Console.WriteLine(triangle.CalculateArea());

            Console.WriteLine();

            Bike bike = new Bike(10, 1);
            bike.Start();
            bike.Stop();

            Console.WriteLine();

            Car car = new Car(110);
            car.Start();
            car.Stop();
            Console.WriteLine(car.GetFuelLevel());
            car.FuelLevel = 0.6;
            Console.WriteLine(car.GetFuelLevel());

            Console.WriteLine();

            Person person = new Person();
            Person person1 = new Person();

            Console.WriteLine(person.Id + " " + person1.Id);
        }
    }
}
