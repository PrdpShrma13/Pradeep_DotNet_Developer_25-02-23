using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace Pradeep_DotNet_Developer.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class Pradeep_DotNet_DeveloperRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<Pradeep_DotNet_DeveloperDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Pradeep_DotNet_DeveloperRepositoryBase(IDbContextProvider<Pradeep_DotNet_DeveloperDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="Pradeep_DotNet_DeveloperRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class Pradeep_DotNet_DeveloperRepositoryBase<TEntity> : Pradeep_DotNet_DeveloperRepositoryBase<TEntity, int>, IRepository<TEntity>
        where TEntity : class, IEntity<int>
    {
        protected Pradeep_DotNet_DeveloperRepositoryBase(IDbContextProvider<Pradeep_DotNet_DeveloperDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
