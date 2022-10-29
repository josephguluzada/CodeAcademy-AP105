namespace AP105_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else-if
            //var number = 74;

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(number + " ededi cutdur");
            //}
            //else
            //{
            //    Console.WriteLine(number + " ededi tekdir");
            //}

            //var number2 = -54;

            //if (number2 > 0)
            //{
            //    Console.WriteLine(number2 + " ededi musbetdir");
            //}
            //else if (number2 == 0)
            //{
            //    Console.WriteLine(number2 + " 0dir");
            //}
            //else
            //{
            //    Console.WriteLine(number2 + " ededi menfidir");
            //}
            #endregion

            #region Switch-Case
            //var choice = 3;

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Bazar ertes");
            //        break;
            //    case 2:
            //        Console.WriteLine("Cershenbe axshami");
            //        break;
            //    case 3:
            //        Console.WriteLine("Cershenbe");
            //        break;
            //    case 4:
            //        Console.WriteLine("Cume axshami");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cume");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Hefte sonu");
            //        break;
            //    default:
            //        Console.WriteLine("Bele gun yoxdur");
            //        break;
            //}
            #endregion

            // Verilmis 4 ededin 3e ve 7 e bolunenlerinin ededi ortasini tapan algorithm

            var num1 = 84;
            var num2 = 21;
            var num3 = 105;
            var num4 = 42;
            var sum = 0;
            var count = 0;
            var avg = 0;

            if(num1 % 21 == 0)
            {
                sum += num1;
                count++;
            }
            if (num2 % 21 == 0)
            {
                sum += num2;
                count++;
            }
            if (num3 % 21 == 0)
            {
                sum += num3;
                count++;
            }
            if (num4 % 21 == 0)
            {
                sum += num4;
                count++;
            }
            if(count > 0)
            {
                avg = sum / count;
                Console.WriteLine("Ededi orta: " + avg);
                Console.WriteLine("Sayi: " + count);
                Console.WriteLine("Cem: " + sum);
            }
            else
            {
                Console.WriteLine("hec biri serti odemir");
            }

            

        }
    }
    
}