namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                FullName = "Rasim Balayev",
                Position = Positions.Student
            };
            Person person2 = new Person
            {
                FullName = "Eli Eliyev",
                Position = Positions.Student
            };
            Person person3 = new Person
            {
                FullName = "Elcin Resulov",
                Position = Positions.Teacher
            };
            Person person4 = new Person
            {
                FullName = "Aga Balayev",
                Position = Positions.Teacher
            };
            Person person5 = new Person
            {
                FullName = "Nicat Rehimov",
                Position = Positions.Teacher
            };

            Person[] people = { person1, person2, person3, person4, person5 };

            Course course = new Course();
            course.Name = "AB102";

            course.AddPerson(people);

            //Person[] wantedPeople = course.GetPeopleByPositionName("StuDenT");
            Person[] wantedPeople = course.GetPeopleByPositionName(1);

            foreach (Person person in wantedPeople)
            {
                Console.WriteLine(person.FullName + " " + person.Position);
            }

        }
    }
}