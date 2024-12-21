using Microsoft.EntityFrameworkCore;
using SigmaSoftwareTest.Common.Interfaces;
using System.Reflection;

namespace SigmaSoftwareTest.Common.Extensions
{
    public static class SoftDeleteFilterExtensions
    {
        public static void SetSoftDeleteFilter(this ModelBuilder modelBuilder, Type entityType)
        {
            SetSoftDeleteFilterMethod.MakeGenericMethod(entityType).Invoke(null, new object[] { modelBuilder });
        }
        static readonly MethodInfo SetSoftDeleteFilterMethod = typeof(SoftDeleteFilterExtensions)
                   .GetMethods(BindingFlags.Public | BindingFlags.Static)
                   .Single(t => t.IsGenericMethod && t.Name == "SetSoftDeleteFilter");
        public static void SetSoftDeleteFilter<TEntity>(this ModelBuilder modelBuilder) where TEntity : class, ISoftDelete
        {
            modelBuilder.Entity<TEntity>().HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
