using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SigmaSoftwareTest.Core.DomainModels;

namespace SigmaSoftwareTest.Infrastructure.Configurations
{
    public class CandidateUserConfiguration : IEntityTypeConfiguration<CandidateUser>
    {
        public void Configure(EntityTypeBuilder<CandidateUser> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}

