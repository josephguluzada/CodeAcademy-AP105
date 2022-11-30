namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher1 = new Teacher();
            teacher1.Fullname = "Rasim Agayev";
            Teacher teacher2 = new Teacher();
            teacher2.Fullname = "Asif Eliyev";
            teacher2.Age = 28;

            Teacher teacher3 = new Teacher();
            teacher3.Fullname = "Elbrus Memmedov";
            teacher3.Age = 20;

            Course course = new Course();
            course.Name = "AB102";
            


            course[3] = teacher3;
            course[4] = teacher1;
            course[5] = teacher2;
            Console.WriteLine(course[5]);

            //foreach (Teacher teacher in course.Teachers)
            //{
            //    Console.WriteLine(teacher);
            //}
        }
    }
}