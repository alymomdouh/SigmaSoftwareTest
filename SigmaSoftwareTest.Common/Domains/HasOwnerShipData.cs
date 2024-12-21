using SigmaSoftwareTest.Common.Interfaces;

namespace SigmaSoftwareTest.Common.Domains
{
    public class HasOwnerShipData : BaseData, ISoftDelete
    {
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdateBy { get; set; }
        public bool IsDeleted { get; set; } = false;
        public void SoftDelete()
        {
            IsDeleted = true;
        }
    }
}
