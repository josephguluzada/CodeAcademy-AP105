using ClassTask.Models;
using ClassTask.Models.Students;
using MyClassLibrary;
namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Teacher teacher = new Teacher();
            Student student = new Student();

            MyCustomClass myCustomClass = new MyCustomClass();

            myCustomClass.ShowText("Derse diqqetle baxin");
        }
    }
}