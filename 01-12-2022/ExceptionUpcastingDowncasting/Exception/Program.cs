using Exception.Exceptions;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Enter number 1");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter number 2");
            //    int b = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Cavab gozlenilir...");
            //    Console.WriteLine(a / b);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0 a bolme bas verdi!");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("soz deyil reqem daxil edin!");
            //}
            //catch (System.Exception)
            //{
            //    Console.WriteLine("Gozlenilmez xeta!");
            //}



            try
            {
                Person person = new Person();

                person.Name = "El";

                Console.WriteLine(person.Name);
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException();
            }
            catch (InvalidNameLengthException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Gozlenilmez xeta!");
            }
            finally
            {
                Console.WriteLine("Finally");
            }


            Console.WriteLine("Ferid");
            Console.WriteLine("Program davam edir");
        }
    }
}