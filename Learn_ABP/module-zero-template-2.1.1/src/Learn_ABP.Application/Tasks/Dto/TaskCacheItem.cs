using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks.Dto
{
    [AutoMapFrom(typeof(Task))]
    public class TaskCacheItem
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
