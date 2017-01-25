using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace scubadivelogs.EntityFramework.Repositories
{
    public abstract class scubadivelogsRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<scubadivelogsDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected scubadivelogsRepositoryBase(IDbContextProvider<scubadivelogsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class scubadivelogsRepositoryBase<TEntity> : scubadivelogsRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected scubadivelogsRepositoryBase(IDbContextProvider<scubadivelogsDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
