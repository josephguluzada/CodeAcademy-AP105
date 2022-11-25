namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Older ways
            //string[] names = { "Ali", "Vali", "Mammad", "Murad" };
            //string[] surnames = { "Aliyev", "Valiyev", "Mammadov", "Muradov" };
            //byte[] ages = { 18, 19, 18,19 };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    //Console.WriteLine(names[i] + " " + surnames[i] + " " + ages[i]);
            //    Console.WriteLine($"Melumatlar: {names[i]} {surnames[i]} {ages[i]}");
            //}

            //var student1 = new
            //{
            //    Name = "Ali",
            //    Surname = "Aliyev",
            //    Age = 19
            //};

            //var student2 = new
            //{
            //    Name = "Vali",
            //    Surname = "Valiyev",
            //    Age = 17,
            //    Point = 89
            //};

            //var student3 = new
            //{
            //    Fullname = "Vali Valiyev",
            //    Age = 17,
            //    Point = 89
            //};

            //Console.WriteLine(student1.Name);
            //Console.WriteLine(student2.Surname);
            #endregion

            //Student std1 = new Student();
            //std1.Name = "Vali";
            //std1.Surname = "Valiyev";
            //std1.Age = 18;
            //std1.Point = 95;

            //Student std2 = new Student
            //{
            //    Name = "Ali",
            //    Surname = "Aliyev",
            //    Age = 19,
            //    Point = 55
            //};

            //Student[] students = { std2,std1 };

            //foreach (Student std in students)
            //{
            //    Console.WriteLine($"{std.Name} {std.Surname} {std.Age} {std.Point} ");
            //}

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine($"{students[i].Name} {students[i].Surname} {students[i].Age} {students[i].Point}");
            //}
            //Human human = new Human();
            //human.Name = "Rasim";
            

            //Student student = new Student();
            //student.Name = "Asif";
            //student.Age = 22;
            //Teacher teacher = new Teacher
            //{
            //    Age = 25,
            //};

            //Console.WriteLine($"Human name: {human.Age} - Student name: {student.Age} - Teacher name: {teacher.Age}");

            //Student student2 = new Student
            //{

            //};

            //Student student1 = new Student();
            //Student student = new Student("Reshad");
            //Student student2 = new Student("Reshad", "Isayev");
            Student student3 = new Student("Reshad", "Isayev", 20,88);
            Console.WriteLine(student3.Name + " " + student3.Surname + " " + student3.Age +" " + student3.Point);

            student3.ShowFullData();

            //Human human = new Human();
            //human.Name = "ELi";
            //human.Surname = "ELiyev";
            //human.Age = 55;

            //human.ShowFullData();
            //string fullname = human.GetFullname();
            //Console.WriteLine(fullname);
        }
    }

    



    class Teacher : Human
    {
        public string Profession;
    }





}