using SigmaSoftwareTest.Common;
using SigmaSoftwareTest.Common.Domains;

namespace SigmaSoftwareTest.Application.Dtos.GenericDto
{
    public record SearchDto : PageRequest
    {
        public bool Sortable { get; set; } = false;
        public string SortField { get; set; } = "CreatedOnDate";
        public SortOrder sortOrder { get; set; } = SortOrder.Ascending;
    }
}
