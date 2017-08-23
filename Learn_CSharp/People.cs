using System;
using System.Collections.Generic;
using System.Text;

namespace Learn_CSharp
{
    class People
    {
        public string Name { get; set; }

        public People()
        {
            Name = "People";
        }

        public string GetName()
        {
            return "People_GetName";
        }

        public virtual string VirtualGetName()
        {
            return "People_VirtualGetName";
        }
    }
}
