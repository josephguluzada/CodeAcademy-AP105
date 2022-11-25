namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            //car.Brand = "Mercedes";
            //car.Model = "E200";
            
            car.CurrentFuel = -60;
            car.FuelFor1Km = 6;
            //car.Millage = 1000;

            Console.WriteLine(car.CurrentFuel);
            Console.WriteLine(car.FuelFor1Km);

            //car.CurrentFuelSetter(80);
            //car.FuelFor1KmSetter(-5);

            //Console.WriteLine(car.CurrentFuelGetter());
            //Console.WriteLine(car.FuelFor1KmGetter());

            //car.Drive(5);
            //car.ShowInfo();
            //car.Drive(3);
            //car.ShowInfo();


            #region Class Task
            Student student = new Student();
            student.Age = 18;
            student.Point = 20;

            Console.WriteLine(student.Age);
            Console.WriteLine(student.Point);



            #endregion

        }
    }
}