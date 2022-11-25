namespace RefOutKeywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum(3,3);
            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10,1,2,3,4,5,6,7,8,9,10));

            //int a = 5;
            //int b = a;
            //b = 8;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = numbers;

            //numbers2[0] = 30;
            //numbers[0] = 45;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("=========================");
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //int a = 7;
            //int d = a; // 7
            //ref int b = ref a;
            //b = 80;
            //ref int c = ref b;
            //c = 90;


            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            int a = 17;
            //Console.WriteLine(a);
            ChangeValueRef(ref a);
            Console.WriteLine("After method: " + a);

            //a += 5;

            //Console.WriteLine(a);

            //ChangeValueOut(out a);

            //Console.WriteLine(a);
            //ChangeValueRef(ref a);
            int age = 17;

            AddOneYear(ref age);

            if (age > 17)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

        static int Sum(int num1 , int num2)
        {
            return num1 + num2;
        }
        
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static void ChangeValueRef(ref int number)
        {
            number = 50;
            Console.WriteLine("in method: " + number);
        }

        static void ChangeValueOut(out int number)
        {
            number = 70;

            Console.WriteLine("in method: " + number);
        }

        static int AddOneYear(ref int age)
        {
            age++;

            return age;
        }
    }
}