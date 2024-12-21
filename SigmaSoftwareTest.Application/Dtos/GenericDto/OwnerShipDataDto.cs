namespace SigmaSoftwareTest.Application.Dtos.GenericDto
{
    public record OwnerShipDataDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedOnDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid LastUpdateBy { get; set; }
    }
}
