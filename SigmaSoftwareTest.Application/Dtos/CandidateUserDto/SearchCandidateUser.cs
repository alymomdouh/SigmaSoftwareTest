using SigmaSoftwareTest.Application.Dtos.GenericDto;

namespace SigmaSoftwareTest.Application.Dtos.CandidateUserDto
{
    public record SearchCandidateUser: SearchDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? GitHubprofileURL { get; set; }
        public string? LinkedInprofileURL { get; set; }
        public string? FreeTextComment { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeOnly? CallTime { get; set; }
    }
}
