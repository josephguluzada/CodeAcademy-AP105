namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print2();

            //int result = Sum(5, 7);
            //result += 5;
            //Console.WriteLine(result);

            //WriteNameToConsole("Elekber");

            //string[] names = { "Eli", "Veli" };
            //int[] numbers = { 4, 6, 7, 9, 10, 13, 15 ,19,21};
            //WriteNumbersToConsole(1,2,3,5,6,7,8,3,5,6);

            Sum(6,3);

            Console.WriteLine(Divide(5.4,9.8,98)); 
        }


        // ReturnTpe olmayan, Parametr qebul etmeyen
        static void Print()
        {
            Console.WriteLine("Hello, AB102");
        }

        // ReturnType olmayan, Parametr qebul eden
        static void WriteNameToConsole(string name)
        {
            if (CheckNameLength(name)) Console.WriteLine(name);
            else Console.WriteLine("Error");
        }

        // ReturnType olan, Parameter qebul etmeyen

        static int ReturnZero()
        {
            return 0;
        }

        // ReturnType olan, Parameter qebul eden

        static int Sum(int num1, int num2)  
        {
            return num1 + num2;
        }

        static double Sum(double num1, int num2)
        {
            return num1 + num2;
        }

        static double Sum(int num2, double num1)
        {
            return num1 + num2;
        }

        static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }

        static int Sum(int num1, int num2, int num3)
        {
            return num2 + num1 + num3;
        }

        static int Sum(int num1, int num2, int num3,int num4)
        {
            return num2 + num1 + num3 + num4;
        }

        static double Divide(double num1, double num2 = 1,double num3 = 1)
        {
            return num1 / num2;
        }


        //static void WriteNumbersToConsole(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}

        static void WriteNumbersToConsole(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void Print2()
        {
            Print();
        }

        static bool CheckNameLength(string name)
        {
            if (name.Length > 5) return true;
            else return false;
        }




    }
}