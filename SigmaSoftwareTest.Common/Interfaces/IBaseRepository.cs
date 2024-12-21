using Microsoft.EntityFrameworkCore.Storage;

namespace SigmaSoftwareTest.Common.Interfaces
{
    public interface IBaseRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
        Task<T> InsertAsync(T entity);
        Task InsertAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task UpdateAsync(IList<T> entities);
        Task<T> DeleteAsync(T entity);
        Task DeleteAsync(IList<T> entities);
        Task<T> Load(Guid id);
        Task<IDbContextTransaction> GetTransaction();
    }
}
