namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            try
            {
                student.Age = -1;
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {

                Console.WriteLine("Xeta!");
            }
        }
    }
}