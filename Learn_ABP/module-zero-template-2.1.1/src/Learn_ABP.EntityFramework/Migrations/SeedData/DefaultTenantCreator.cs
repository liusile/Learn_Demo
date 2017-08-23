using System.Linq;
using Learn_ABP.EntityFramework;
using Learn_ABP.MultiTenancy;

namespace Learn_ABP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly Learn_ABPDbContext _context;

        public DefaultTenantCreator(Learn_ABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
