using System.Linq;
using Abp.Application.Editions;
using Learn_ABP.Editions;
using Learn_ABP.EntityFramework;

namespace Learn_ABP.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly Learn_ABPDbContext _context;

        public DefaultEditionsCreator(Learn_ABPDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}