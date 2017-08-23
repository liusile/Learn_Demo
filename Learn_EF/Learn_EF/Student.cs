using System.ComponentModel.DataAnnotations;

namespace Learn_EF
{
    public class Student
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Teacher Teacher { get; set; }
    }
}