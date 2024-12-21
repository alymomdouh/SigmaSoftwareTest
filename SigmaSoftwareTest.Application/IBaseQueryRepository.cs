namespace SigmaSoftwareTest.Application
{
    public interface IBaseQueryRepository<T> where T : class
    {
        IQueryable<T> Table { get; }
    }
}
