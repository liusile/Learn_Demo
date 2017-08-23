using System.Data.Common;
using Abp.Zero.EntityFramework;
using Learn_ABP.Authorization.Roles;
using Learn_ABP.Authorization.Users;
using Learn_ABP.MultiTenancy;
using System.Data.Entity;
using Learn_ABP.Tasks;

namespace Learn_ABP.EntityFramework
{
    public class Learn_ABPDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Task> Tasks { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public Learn_ABPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in Learn_ABPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of Learn_ABPDbContext since ABP automatically handles it.
         */
        public Learn_ABPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public Learn_ABPDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public Learn_ABPDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
