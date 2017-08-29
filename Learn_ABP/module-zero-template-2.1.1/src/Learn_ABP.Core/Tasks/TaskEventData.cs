using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks
{
    public class TaskEventData:EventData
    {
        public string Name { get; set; }
        public TaskEventData(string name)
        {
            this.Name = name;
        }
    }
}
