using AccessModifiers.Models.Students;
using AccessModifiers.Models;
using MyCustomLibrary;
using System.Text;
using StringBuilder = System.Text.StringBuilder;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder  stringBuilder = new StringBuilder();
            AccessModifiers.Models.StringBuilder stringBuilder1 = new AccessModifiers.Models.StringBuilder();
            StringBuilder  stringBuilder2 = new StringBuilder();

            Human human = new Human();
            Teacher teacher = new Teacher();
            TestClass testClass = new TestClass();
            Student student = new Student();

            CustomMath customMath = new CustomMath();


            //Console.WriteLine(customMath.Sum(5, 7));
            customMath.ShowSum(10, 5);
        }
    }
}