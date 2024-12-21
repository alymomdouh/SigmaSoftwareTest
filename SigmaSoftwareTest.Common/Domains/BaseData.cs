using System.ComponentModel.DataAnnotations;

namespace SigmaSoftwareTest.Common.Domains
{
    public class BaseData
    {
        [Required]
        public Guid Id { get; }
    }
}
