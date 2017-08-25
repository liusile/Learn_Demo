using Abp.Domain.Repositories;
using Learn_ABP.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learn_ABP.IRepositories
{
    public  interface IBackendTaskRepository:IRepository<Task>
    {
        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId"></param>
        /// <returns></returns>
        List<Task> GetTaskByAssignedPersonId(long personId);
    }
}
