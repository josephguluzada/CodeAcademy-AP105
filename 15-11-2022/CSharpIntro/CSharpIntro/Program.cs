namespace CSharpIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Yusif";

            //if(name.Length >= 7)
            //{
            //    Console.WriteLine("Duzgundur");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlishdir");
            //}

            //while (name.Length <7)
            //{
            //    Console.WriteLine("Yanlisdir yeniden daxil edin");
            //    name = Console.ReadLine();
            //}

            //do
            //{
            //    Console.WriteLine("Please,enter the name");
            //    name = Console.ReadLine();
            //} while (name.Length <7);

            //for (; ;)
            //{
            //    if(name.Length >= 7)
            //    {
            //        Console.WriteLine("Duzgundur");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Adinizi daxil edin:");
            //        name = Console.ReadLine();
            //    }
            //}

            //for (int i = 0,j = 0; i <= 100; i++,j--)
            //{
            //    if(i == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + " " + j);
            //}

            for (int i = 0; i < 100; i=i)
            {
                Console.WriteLine("");
            }

            int a = 87;

            int num1 = 0;

            int num2 = 0;

            num1 = a / 10; // 8

            num2 = a % 10; // 7

            Console.WriteLine(num2 + "" + num1);
        }
    }
}