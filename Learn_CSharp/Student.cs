using System;
using System.Collections.Generic;
using System.Text;

namespace Learn_CSharp
{
    class Student : People
    {
        //也可以省略Name
        new string Name { get; set; }

        public Student()
        {
            Name = "Student";
        }

        new public string GetName()
        {
            return "Student_GetName";
        }
        public string BaseGetName()
        {
            return base.GetName();
        }

        public override string VirtualGetName()
        {
            return "Student_VirtualGetName";
        }

    }
}