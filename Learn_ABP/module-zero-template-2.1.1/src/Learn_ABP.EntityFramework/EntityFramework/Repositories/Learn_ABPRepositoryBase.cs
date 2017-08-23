using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Learn_ABP.EntityFramework.Repositories
{
    public abstract class Learn_ABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<Learn_ABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Learn_ABPRepositoryBase(IDbContextProvider<Learn_ABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class Learn_ABPRepositoryBase<TEntity> : Learn_ABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected Learn_ABPRepositoryBase(IDbContextProvider<Learn_ABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
