using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_EF
{
    public class Province
    {
        public int Id { get; set; }
            public string Name { get; set; }
      
            public virtual Governor Governor { get; set; }
     
            public virtual List<City> Cities { get; set; }
    }
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }    
    public class Governor
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
