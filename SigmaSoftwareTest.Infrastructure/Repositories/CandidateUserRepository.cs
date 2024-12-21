using SigmaSoftwareTest.Core.DomainModels;
using SigmaSoftwareTest.Core.IRepositories;

namespace SigmaSoftwareTest.Infrastructure.Repositories
{
    public class CandidateUserRepository : BaseRepository<CandidateUser>, ICandidateUserRepository
    {
        public CandidateUserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
