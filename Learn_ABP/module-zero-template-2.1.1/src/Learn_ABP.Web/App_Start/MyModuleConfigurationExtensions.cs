using Abp.Configuration.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learn_ABP.Web.App_Start
{
    public static class MyModuleConfigurationExtensions
    {
        public static MyModuleConfig MyModule(this IModuleConfigurations moduleConfigurations)
        {
            return moduleConfigurations.AbpConfiguration.GetOrCreate("MyModuleConfig",
                () => moduleConfigurations.AbpConfiguration.IocManager.Resolve<MyModuleConfig>());
        }
    }
}