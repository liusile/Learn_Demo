using Abp.Application.Services;
using Abp.Dependency;
using Abp.Runtime.Caching;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Controllers;
using Castle.Core.Logging;
using Learn_ABP.Tasks;
using Learn_ABP.Tasks.Dto;
using Learn_ABP.Users;
using Learn_ABP.Web.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_ABP.Web.Controllers
{
    public class TasksController : AbpController
    {
        private readonly ITaskAppService _taskAppService;
        private readonly IUserAppService _userAppService;
        private readonly IIocManager _iocManager;
        private readonly ICacheManager _cacheManager;
        public ILogger Logger { get; set; }
        public TasksController(IIocManager iocManager, ITaskAppService taskAppService, IUserAppService userAppService, ICacheManager iCacheManager)
        {
            _taskAppService = taskAppService;
            _userAppService = userAppService;
            _iocManager = iocManager;
            _cacheManager = iCacheManager;
            Logger = NullLogger.Instance;
        }

        // GET: Tasks
        public ActionResult Index()
        {
            Logger.Debug("这是我做得日志记录呀");
            // var data = _cacheManager.GetCache<string, IList<TaskDto>>("ControllerCache").Get("Index", () => _taskAppService.GetAllTasks());
            var data = _taskAppService.GetAllTasks();
            return View(data);
            
        }
        public ActionResult Update()
        {
            _taskAppService.UpdateTask(new UpdateTaskInput
            {
                Id = 1,
                Title = "title3",
                Description = "Descri",
                State = TaskState.Completed
            });
            return RedirectToAction("Index");
        }
        public ActionResult GetTask()
        { 
            var data = _taskAppService.GetTaskById(1);
            TempData["Title"] = data.Title;
            return RedirectToAction("Index");

        }
    }
}