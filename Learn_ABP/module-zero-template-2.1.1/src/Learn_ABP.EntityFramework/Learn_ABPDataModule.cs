using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Learn_ABP.EntityFramework;

namespace Learn_ABP
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(Learn_ABPCoreModule))]
    public class Learn_ABPDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Learn_ABPDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
