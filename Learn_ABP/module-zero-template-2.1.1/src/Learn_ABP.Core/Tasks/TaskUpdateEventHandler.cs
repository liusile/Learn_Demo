using Abp.Events.Bus.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks
{
    class TaskUpdateEventHandler : EntityUpdatedEventData<Task>
    {
        public TaskUpdateEventHandler(Task entity) : base(entity)
        {
            Debug.Write("Task Update Event Happen");
        }
    }
}
