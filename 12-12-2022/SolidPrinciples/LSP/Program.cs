namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person developer = new Developer();
            Console.WriteLine(developer.GetFullName());
            //Console.WriteLine(developer.GetExperience());

            Person teacher = new Teacher();
            Console.WriteLine(teacher.GetFullName());
            //Console.WriteLine(teacher.GetExperience());

            Person student = new Student();
            Console.WriteLine(student.GetFullName());
            //Console.WriteLine(student.GetExperience());
        }
    }
}