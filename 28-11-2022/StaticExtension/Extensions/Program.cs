namespace Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "yuSiF";
            Console.WriteLine(name.ToCapitalize());

            string str = "reShAd";
            Console.WriteLine(str.ToCapitalize());

            int number = 6;

            Console.WriteLine(number.IsEven());
            Console.WriteLine(number.Add(10));

        }
    }
}