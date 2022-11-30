namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Name = "Akif";
            student.Age = 18;

            ChangeValue(student.Age);
            ChangeNameValue(student);

            Console.WriteLine(student.Name + " " + student.Age);
        }


        static void ChangeValue(byte value)
        {
            value = 90;
        }

        static void ChangeNameValue(Student student)
        {
            student.Name = "Eziz";
        }
    }
}