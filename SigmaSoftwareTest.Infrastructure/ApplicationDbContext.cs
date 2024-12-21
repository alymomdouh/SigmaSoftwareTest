using Microsoft.EntityFrameworkCore;
using SigmaSoftwareTest.Common.Interfaces;
using System.Reflection;
using SigmaSoftwareTest.Common.Extensions;
using SigmaSoftwareTest.Core.DomainModels;

namespace SigmaSoftwareTest.Infrastructure
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);

            // For Retrevie only not Deleted (Soft Delete)
            foreach (var type in builder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDelete).IsAssignableFrom(type.ClrType))
                    builder.SetSoftDeleteFilter(type.ClrType);
            }

        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

            // get current userId 
            // save data HasOwnerShipData
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken); ;

        }
        public DbSet<CandidateUser> CandidateUsers { get; set; }
    }

}
