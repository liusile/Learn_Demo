using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Learn_ABP.EntityFramework;

namespace Learn_ABP.Migrator
{
    [DependsOn(typeof(Learn_ABPDataModule))]
    public class Learn_ABPMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<Learn_ABPDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}