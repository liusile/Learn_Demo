using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Learn_ABP.EntityFramework;
using Learn_ABP.Tasks;

namespace Learn_ABP.Migrations.SeedData
{
    class DefaultTestDataForTask
    {
        private Learn_ABPDbContext context;
        private static readonly List<Task> _tasks;
        public DefaultTestDataForTask(Learn_ABPDbContext context)
        {
            this.context = context;
        }
        static DefaultTestDataForTask()
        {
            _tasks = new List<Task>()
          {
              new Task("Learning ABP deom", "Learning how to use abp framework to build a MPA application."),
              new Task("Make Lunch", "Cook 2 dishs")
          };
        }
        internal void Create()
        {
            foreach (var task in _tasks)
            {
                if (context.Tasks.FirstOrDefault(t => t.Title == task.Title) == null)
                {
                    context.Tasks.Add(task);
                }
            }
            context.SaveChanges();
        }
    }
}
