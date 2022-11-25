namespace ClassBaseThis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human("Rufet","Eliyev",19);

            //Console.WriteLine(human.Name + " " + human.Surname + " " + human.Age);

            Student student = new Student("Eli", "Eliyev", 18, 78.5,113);

            Console.WriteLine($"{student.Name} {student.Surname} {student.Age} {student.Point} {student.Grant}");
        }
    }
}