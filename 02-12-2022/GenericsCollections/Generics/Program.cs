namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClassTask
            Student student1 = new Student();
            student1.Name = "Eli";
            student1.SurName = "Eliyev";
            Student student2 = new Student();
            student2.Name = "Veli";
            student2.SurName = "Veliyev";
            Student student3 = new Student();
            student3.Name = "Pirveli";
            student3.SurName = "Pivelizada";

            //StudentList studentList = new StudentList();
            //studentList.Add(student1);
            //studentList.Add(student2);
            //studentList.Add(student3);
            //Console.WriteLine("Studentlist 1:");
            //Console.WriteLine(studentList.Count());

            //StudentList studentList1 = new StudentList();
            //Console.WriteLine("Studentlist 2:");

            //Console.WriteLine(studentList1.Count());

            //foreach (Student std in studentList.Students)
            //{
            //    Console.WriteLine(std);
            //}

            //Console.WriteLine(studentList.Count());

            //try
            //{
            //    Student wantedStd1 = studentList.FindByIndex(3);
            //    Console.WriteLine(wantedStd1.Name);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen xeta!");
            //}
            #endregion

            //int a = 8;
            //int b = 9;
            //int c = 10;

            //IntList intList = new IntList();
            //intList.Add(a);
            //intList.Add(b);
            //intList.Add(c);

            //foreach (int item in intList.numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(intList.Count());

            //try
            //{
            //    int wantedInt = intList.FindByIndex(0);
            //    Console.WriteLine(wantedInt);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Bilinmeyen xeta!");
            //}

            MyList<Student> myList = new MyList<Student>();

            myList.Add(student1);
            myList.Add(student2);
            myList.Add(student3);

            foreach (Student std in myList.values)
            {
                Console.WriteLine(std);
            }
            Console.WriteLine(myList.FindByIndex(0));


            MyList<string> myList2 = new MyList<string>();

            myList2.Add("Behruz");
            myList2.Add("Huseyn");
            myList2.Add("Nihad");

            for (int i = 0; i < myList2.values.Length; i++)
            {
                Console.WriteLine(myList2.values[i]);
            }

            Console.WriteLine(myList2.FindByIndex(0));
        }
    }
}