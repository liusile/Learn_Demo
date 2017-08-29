using Abp.Domain.Entities.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_ABP.Tasks.Dto
{
    public interface ITaskCache:IEntityCache<TaskCacheItem>
    {
    }
}
