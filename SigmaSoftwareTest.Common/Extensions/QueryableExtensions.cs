using Microsoft.VisualBasic;
using SigmaSoftwareTest.Common.Domains;

namespace SigmaSoftwareTest.Common.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> querable, PageRequest pageRequest)
        {
            if (pageRequest.Page >= 1 && pageRequest.Page <= pageRequest.PageSize)
            {
                return querable.Skip((pageRequest.Page - 1) * pageRequest.PageSize).Take(pageRequest.PageSize);

            }
            else
            {
                //TODO : need testing (It works only with prime ng table pagination page in this case is page )
                return querable.Skip(pageRequest.Page).Take(pageRequest.PageSize);

            }
        }
        public static IQueryable<T> GetAllLimit<T>(this IQueryable<T> querable)
        {
            return querable.Take(Constants.PageSizeLimit);
        }
    }
}
