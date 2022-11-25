namespace Array_BigO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = 78;

            //int[] numbers2 = new int[3] { 1, 2,0 };
            //int[] numbers3 = new int[] { 1, 2, 3,4 };
            //int[] numbers4 = { 1, 2, 3,4 ,5};
            //int[] numbers = new int[4];
            //numbers[0] = 15;
            //numbers[1] = 16;
            //numbers[2] = 17;
            //numbers[3] = 18;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] names = new string[3] { "Eli", "Veli", "Rasim" };



            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //int[] inputNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum = 0;

            //for (int i = 0; i < inputNumbers.Length; i++)
            //{
            //    sum += inputNumbers[i];
            //    Console.WriteLine("Element: " + inputNumbers[i]);
            //    Console.WriteLine("Index " + i);
            //}
            //Console.WriteLine("Cem: " + sum);

            int[] numbers = { 1, 2, 3 };
            int[,] numbers2 = { { 1, 2, 3 }, { 3, 4, 5 } };

            int lastIndex = numbers[numbers.Length-1];

            Console.WriteLine("netice : " + lastIndex);
            Console.WriteLine(numbers2[1,1]);

            int n = 998;
            int count = 0;
            bool check = false;
            if(n == 1)
            {
                Console.WriteLine("Ne sade ne murekkebdir");
            }

            if(n == 2)
            {
                Console.WriteLine("Sade eddedir");
            }

            for (int i = 2; i*i <= n; i++)
            {
                count++;
                if(n % i == 0)
                {
                    check = true;
                    break;
                }
            }

            if(n != 1 && n != 2)
            {
                if (check == true)
                {
                    Console.WriteLine("Murekkebdir");
                }
                else
                {

                    Console.WriteLine("Sadedir");
                }
            }
            
            Console.WriteLine("Dongu sayi: " + count);

        }
    }
}