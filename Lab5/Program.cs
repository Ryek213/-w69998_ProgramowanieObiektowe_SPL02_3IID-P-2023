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

            Console.WriteLine();


        }
    }
}
