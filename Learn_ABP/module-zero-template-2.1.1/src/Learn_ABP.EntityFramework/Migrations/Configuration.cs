using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Learn_ABP.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Learn_ABP.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<Learn_ABP.EntityFramework.Learn_ABPDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Learn_ABP";
        }

        protected override void Seed(Learn_ABP.EntityFramework.Learn_ABPDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }
            new DefaultTestDataForTask(context).Create();
            context.SaveChanges();
        }
    }
}
