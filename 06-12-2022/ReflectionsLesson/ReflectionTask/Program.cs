using System.Reflection;

namespace ReflectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            Teacher teacher = new();

            foreach (Type type in types)
            {
                if(type == typeof(Teacher))
                {
                    Console.WriteLine("Type names: ");
                    Console.WriteLine("\t" + type.Name);

                    Console.WriteLine("Property name:");
                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        Console.WriteLine("\t" + property.Name);
                    }

                    Console.WriteLine("Field name:");
                    foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        if (field.Name == "_name") field.SetValue(teacher, "Eli Elekberov");
                        Console.WriteLine("\t" + field.Name + " " + field.GetValue(teacher));
                    }

                    Console.WriteLine("Method name:");
                    foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                    {
                        Console.WriteLine("\t" + method.Name);
                    }
                }
            }
        }
    }
}