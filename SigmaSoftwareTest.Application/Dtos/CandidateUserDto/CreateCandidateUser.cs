using System.ComponentModel.DataAnnotations;

namespace SigmaSoftwareTest.Application.Dtos.CandidateUserDto
{
    public class CreateCandidateUser
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string? GitHubprofileURL { get; set; }
        public string? LinkedInprofileURL { get; set; }
        [Required(ErrorMessage = "Free Text Comment is required")]
        public string FreeTextComment { get; set; }
        public string? PhoneNumber { get; set; }
        public TimeOnly? CallTime { get; set; }
    }
}
