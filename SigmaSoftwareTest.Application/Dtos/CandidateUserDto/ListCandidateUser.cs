using SigmaSoftwareTest.Application.Dtos.GenericDto;
using SigmaSoftwareTest.Core.DomainModels;

namespace SigmaSoftwareTest.Application.Dtos.CandidateUserDto
{
    public record ListCandidateUser : OwnerShipDataDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string GitHubprofileURL { get; set; }
        public string LinkedInprofileURL { get; set; }
        public string FreeTextComment { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeOnly? CallTime { get; set; }
        public static explicit operator ListCandidateUser(CandidateUser item)
        {
            return new ListCandidateUser
            {
                Id = item.Id,
                CallTime = item.CallTime,
                FreeTextComment = item.FreeTextComment,
                PhoneNumber = item.PhoneNumber,
                GitHubprofileURL = item.GitHubprofileURL,
                LinkedInprofileURL = item.LinkedInprofileURL,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Email = item.Email,
                CreatedBy = item.CreatedBy,
                CreatedOnDate = item.CreatedOnDate,
                LastUpdateBy = item.LastUpdateBy,
                LastUpdateDate = item.LastUpdateDate
            };
        }
    }
}
