using Abp.Domain.Entities.Caching;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks.Dto
{
    public class TaskDtoCache:EntityCache<Task, TaskCacheItem>
    {
        public TaskDtoCache(ICacheManager cacheManager, IRepository<Task> repository)
        : base(cacheManager, repository)
        {

        }
       
       
    }
}
