using Learn_ABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Learn_ABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly Learn_ABPDbContext _context;

        public InitialHostDbBuilder(Learn_ABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
