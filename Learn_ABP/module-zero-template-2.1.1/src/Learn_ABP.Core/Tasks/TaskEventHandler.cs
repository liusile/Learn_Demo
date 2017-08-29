using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks
{
    public class TaskEventHandler : IEventHandler<TaskEventData>, ITransientDependency
    {

        public void HandleEvent(TaskEventData eventData)
        {
            Debug.Write(eventData.Name);
        }
      
    }
    public class TaskEventHandler1 : IEventHandler<TaskEventData>, ITransientDependency
    {
        public void HandleEvent(TaskEventData eventData)
        {
            Debug.Write("TaskEventHandler1" + eventData.Name);
        }
    }
}
