using ReflectionsLesson.Models;
using System.Reflection;

namespace ReflectionsLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Teacher teacher = new();
            teacher.Name = "Farid";

            var type1 = typeof(Teacher);
            Console.WriteLine(nameof(Teacher));

            Console.WriteLine(type1.Name);

            foreach (Type type in assembly.GetTypes())
            {
                if(type == typeof(Teacher))
                {
                    //Console.WriteLine("Types: ");
                    //Console.WriteLine("\t" + type.Name);
                    //Console.WriteLine("Propeties:");
                    //foreach (PropertyInfo property in type.GetProperties())
                    //{
                    //    Console.WriteLine("\t" + property);
                    //}
                    Console.WriteLine("Field:");
                    foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (field.Name == "_id")
                        {
                            field.SetValue(teacher, 900);
                        }
                        Console.WriteLine("\t" + field.Name + " - " + field.GetValue(teacher) );
                    }

                    //Console.WriteLine("Methods:");
                    //foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                    //{
                    //    Console.WriteLine(method);
                    //}
                }
            }
            teacher.Id = 800;
            Console.WriteLine(teacher.Id);


            foreach (Type type in assembly.GetTypes())
            {
                if (type == typeof(Teacher))
                {
                    //Console.WriteLine("Types: ");
                    //Console.WriteLine("\t" + type.Name);
                    //Console.WriteLine("Propeties:");
                    //foreach (PropertyInfo property in type.GetProperties())
                    //{
                    //    Console.WriteLine("\t" + property);
                    //}
                    Console.WriteLine("Field:");
                    foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (field.Name == "_id")
                        {
                            field.SetValue(teacher, 900);
                        }
                        Console.WriteLine("\t" + field.Name + " - " + field.GetValue(teacher));
                    }

                    //Console.WriteLine("Methods:");
                    //foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                    //{
                    //    Console.WriteLine(method);
                    //}
                }
            }
        }
    }
}