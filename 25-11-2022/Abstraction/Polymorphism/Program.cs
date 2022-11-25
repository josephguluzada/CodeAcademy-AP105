namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Name = "Eli";
            human.Surname = "Eliyev";
            human.Age = 15;
            human.ShowFullData();

            Student student = new Student();
            student.Name = "Veli";
            student.Surname = "Veliyev";
            student.Age = 25;
            student.Point = 77;
            student.ShowFullData();

            Human human2 = student;
            human2.ShowFullData();


            Teacher teacher = new Teacher();
            teacher.Name = "PirVeli";
            teacher.Surname = "Veliyev";
            teacher.Age = 29;
            teacher.Experience = 7;
            teacher.ShowFullData();

            Human human3 = teacher;
            human3.ShowFullData();
        }
    }
}