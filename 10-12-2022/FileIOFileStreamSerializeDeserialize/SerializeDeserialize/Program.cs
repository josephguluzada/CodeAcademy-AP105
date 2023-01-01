using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializeDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Employee employee = new Employee();

            //employee.Id = 15;
            //employee.Name = "Ali";
            //employee.Surname = "Aliyev";
            //employee.Age = 27;

            //SerializeEmployeeToBinary(employee);

            //Employee employee2 = DeserializeFromBinaryToEmployee();

            //Console.WriteLine(employee2);

            //SerializeEmployeeToXML(employee);

            Employee employee3 = DeserializeFromXMLToEmployee();
            Console.WriteLine(employee3);
        }

        // C# objectini Binary formatina cevirdik
        public static void SerializeEmployeeToBinary(Employee employee)
        {
            string path = "C:\\Users\\asus\\Desktop\\Employee.dat";
            Stream stream = new FileStream(path, FileMode.Create);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, employee);
        }

        // Binary formatindan C# objectine cevirdik
        public static Employee DeserializeFromBinaryToEmployee()
        {
            string path = "C:\\Users\\asus\\Desktop\\Employee.dat";
            Stream stream = new FileStream(path, FileMode.Open);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            var employee = (Employee)binaryFormatter.Deserialize(stream);

            return employee;
        }
        // C# objectini XML formatina cevirdik
        public static void SerializeEmployeeToXML(Employee employee)
        {
            string path = "C:\\Users\\asus\\Desktop\\Employee.xml";
            Stream stream = new FileStream(path,FileMode.Create);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            xmlSerializer.Serialize(stream, employee);
        }

        // XML formatindan C# objectine cevirdik
        public static Employee DeserializeFromXMLToEmployee()
        {
            string path = "C:\\Users\\asus\\Desktop\\Employee.xml";
            Stream stream = new FileStream(path, FileMode.Open);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            var employee = (Employee)xmlSerializer.Deserialize(stream);

            return employee;
        }


    }
}