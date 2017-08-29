using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks
{
    public class TaskAggregateRoot: AggregateRoot<Task>
    {
        public void Insert(Task task)
        {
           
        }
    }
}
