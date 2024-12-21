using SigmaSoftwareTest.Common.Domains;
using SigmaSoftwareTest.Common.Interfaces;

namespace SigmaSoftwareTest.Core.DomainModels
{
    public class CandidateUser : HasOwnerShipData, IAggregateRoot
    { 
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string GitHubprofileURL { get; private set; }
        public string LinkedInprofileURL { get; private set; }
        public string FreeTextComment { get; private set; }
        public string? PhoneNumber { get; private set; }
        public TimeOnly? CallTime { get; private set; }

        public CandidateUser(string firstName, string lastName, string email, string gitHubprofileURL, string linkedInprofileURL, string freeTextComment, string? phoneNumber, TimeOnly? callTime)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            GitHubprofileURL = gitHubprofileURL;
            LinkedInprofileURL = linkedInprofileURL;
            FreeTextComment = freeTextComment;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }
        public void ChangeData(string firstName, string lastName, string email, string gitHubprofileURL, string linkedInprofileURL, string freeTextComment, string? phoneNumber, TimeOnly? callTime)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            GitHubprofileURL = gitHubprofileURL;
            LinkedInprofileURL = linkedInprofileURL;
            FreeTextComment = freeTextComment;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }
    }
}
