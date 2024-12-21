using Microsoft.EntityFrameworkCore;
using SigmaSoftwareTest.Application;

namespace SigmaSoftwareTest.Infrastructure
{
    public class BaseQueryRepository<T> : IBaseQueryRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        public BaseQueryRepository(ApplicationDbContext context)
        {
            _entities = context.Set<T>();
        }
        public IQueryable<T> Table => _entities;
    }
}
