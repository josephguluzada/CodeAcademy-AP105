using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDeserialize
{
    [Serializable]
    public class Employee : ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id",Id,typeof(int));
            info.AddValue("Name",Name,typeof(string));
            info.AddValue("Surname", Surname, typeof(string));
            info.AddValue("Age", Age, typeof(byte));
        }


        public Employee()
        {

        }
        public Employee(SerializationInfo info, StreamingContext context)
        {
            Id = (int)info.GetValue("Id", typeof(int));
            Name = (string)info.GetValue("Name", typeof(string));
            Surname = (string)info.GetValue("Surname", typeof(string));
            Age = (byte)info.GetValue("Age", typeof(byte));
        }




        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Age}";
        }
    }
}
