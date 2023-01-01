namespace _29122022.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public int TeacherId { get; set; }
    }
}
