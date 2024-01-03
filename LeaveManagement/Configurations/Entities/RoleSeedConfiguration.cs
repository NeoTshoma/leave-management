using System.Xml.Linq;
using LeaveManagement.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "2b52b2e5-5b73-4892-81bd-0f038224117c",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole{
                Id = "82684b01-e724-4539-9426-8c09f6b312b8",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }

                );
        }
    }
}