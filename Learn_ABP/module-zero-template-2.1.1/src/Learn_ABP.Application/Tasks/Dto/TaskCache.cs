using Abp.Domain.Entities.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using Learn_ABP.Tasks.Dto;
using Abp.Dependency;

namespace Learn_ABP.Tasks.Dto
{
    public class TaskCache : EntityCache<Task, TaskCacheItem>, ITaskCache,ITransientDependency
    {
        public TaskCache(ICacheManager cacheManager, IRepository<Task> repository) : base(cacheManager, repository)
        {
        }
    }
}
