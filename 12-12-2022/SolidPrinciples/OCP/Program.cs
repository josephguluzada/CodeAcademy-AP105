namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator area = new AreaCalculator();

            Console.WriteLine(area.AreaCalcul(new Triangle { Side = 10,Height = 5}));
            Console.WriteLine(area.AreaCalcul(new Circle { Radius = 10}));
            Console.WriteLine(area.AreaCalcul(new Rectangle { Height = 10,Width=8}));
        }
    }
}