using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Course
    {
        public string Name { get; set; }
        public Person[] people;

        public Course()
        {
            people = new Person[0];
        }

        public void AddPerson(Person person)
        {
            Array.Resize(ref people, people.Length + 1);
            people[^1] = person;
        }
        public void AddPerson(Person[] newPeople)
        {
            for (int i = 0; i < newPeople.Length; i++)
            {
                AddPerson(newPeople[i]);
            }
        }


        public void AddPerson(Person person,ref Person[] newArr)
        {
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[^1] = person;
        }

        public Person[] GetPeopleByPositionName(string value)
        {
            Person[] newPeople = new Person[0];
            foreach (Person person in people)
            {
                if(person.Position.ToString().ToLower() == value.ToLower())
                {
                    AddPerson(person,ref newPeople);

                }
            }
            return newPeople;
        }

        public Person[] GetPeopleByPositionName(int value) //Teacher 
        {
            Person[] newPeople = new Person[0];
            foreach (Person person in people)
            {
                if ((int)person.Position == value)
                {
                    AddPerson(person, ref newPeople);

                }
            }
            return newPeople;
        }
    }
}
