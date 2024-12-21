namespace SigmaSoftwareTest.Common.Interfaces
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
        void SoftDelete();
    }
}
