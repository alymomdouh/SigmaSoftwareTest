using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SigmaSoftwareTest.Common.Interfaces;

namespace SigmaSoftwareTest.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IAggregateRoot
    {
        private readonly DbSet<T> _entities;
        protected readonly ApplicationDbContext Context;

        public IUnitOfWork UnitOfWork => Context;


        public BaseRepository(ApplicationDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = context.Set<T>();

        }
        public async Task<T> InsertAsync(T entity)
        {
            var addedEntity = await _entities.AddAsync(entity);
            return addedEntity.Entity;
        }

        public async Task InsertAsync(IList<T> entities)
        {
            //if (entities.Count > Constants.EntitiesLimit)
            //    throw new ApprovalException("You exceeded entities' limit");
            await _entities.AddRangeAsync(entities);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var updatedEntity = _entities.Update(entity);
            return updatedEntity.Entity;
        }

        public async Task UpdateAsync(IList<T> entities)
        {
            //if (entities.Count > Constants.EntitiesLimit)
            //    throw new ApprovalException("You exceeded entities' limit");

            _entities.UpdateRange(entities);
        }

        public async Task<T> DeleteAsync(T entity)
        {
            var updatedEntity = _entities.Remove(entity);
            return updatedEntity.Entity;
        }

        public async Task DeleteAsync(IList<T> entities)
        {
            _entities.RemoveRange(entities);
        }

        public virtual async Task<T> Load(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IDbContextTransaction> GetTransaction()
        {
            return await Context.Database.BeginTransactionAsync();
        }
    }
}
