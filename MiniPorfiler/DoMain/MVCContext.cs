using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMain
{
    public class MVCContext:DbContext
    {
        public MVCContext():base("MiniPorfilerDemo"){
            }
        public DbSet<Student>  Student{ get; set; }
    }
}
