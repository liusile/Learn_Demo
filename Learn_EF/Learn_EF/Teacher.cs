using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_EF
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Student> Student { get; set; }
    }
}
