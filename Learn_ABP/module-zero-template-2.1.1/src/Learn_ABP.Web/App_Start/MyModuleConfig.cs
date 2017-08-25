using System;
using Abp.Dependency;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Learn_ABP.Web.App_Start
{
    public class MyModuleConfig: IWindsorInstaller
    {
        public bool SampleConfig1  { get; set; }
        public string SampleConfig2 { get; set; }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<MyModuleConfig>());
        }
    }
}