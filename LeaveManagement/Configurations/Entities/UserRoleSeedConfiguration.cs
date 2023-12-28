using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "533afdab-494e-4ea3-af97-60dd8053dbd9",
                    RoleId = "2b52b2e5-5b73-4892-81bd-0f038224117c"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "82684b01-e724-4539-9426-8c09f6b312b8",
                    UserId = "82684b01-e624-4539-9426-8c09f6b312b8"
                }

            );
        }
    }
}