using System.Security.Cryptography;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 5, 9, 14, 19, 22, 28, 48, 76, 90, 110, 145, 271, 385, 400 };
            //int input = 110;
            //int count = 0;


            //// Linear search
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    count++;
            //    if (numbers[i] == input)
            //    {
            //        Console.WriteLine("eded " + i + " indexdedir. Addim sayi: " + count);
            //        break;
            //    }
            //}


            // Binary search

            int[] numbers = { 1, 5, 9, 14, 19, 22, 28, 48, 76, 90, 110, 145, 271, 385, 400 };
            int min = 0;
            int max = numbers.Length - 1;
            int input = 5;
            int mid = default(int);
            int count = 0;
            bool check = false;

            while (min <= max)
            {
                count++;
                mid = (min + max) / 2;
                if(numbers[mid] == input) // Ortadaki eded beraberdir mi inputa?
                {
                    check = true;
                    break;
                }
                else if (numbers[mid] < input) // ortadaki kicikdir mi inputdan
                {
                    min = mid + 1;
                }
                else // ortadaki boyukdur mu inputdan
                {
                    max = mid - 1;
                }
            }

            if(check)
            {
                Console.WriteLine("eded " + mid + " indexdedir. Addim sayi: " + count);
            }
            else
            {
                Console.WriteLine("Axtardiginiz eded arrayde yoxdur");
            }

        }
    }
}