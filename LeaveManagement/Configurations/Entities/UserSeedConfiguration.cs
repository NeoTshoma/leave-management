using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "533afdab-494e-4ea3-af97-60dd8053dbd9",
                    Email = "neosellotshoma1@gmail.com",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "neosellotshoma1@gmail.com",
                    NormalizedUserName = "NEOSELLOTSHOMA1@gmail.com",
                    NormalizedEmail = "NEOSELLOTSHOMA1@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "Neo89243*"),
                    TaxId = "12Test",
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "82684b01-e624-4539-9426-8c09f6b312b8",
                    Email = "neosellotshoma@gmail.com",
                    FirstName = "System",
                    LastName = "User",
                    NormalizedUserName = "NEOSELLOTSHOMA@gmail.com",
                    NormalizedEmail = "NEOSELLOTSHOMA@gmail.com",
                    UserName = "neosellotshoma@gmail.com",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    TaxId = "13Test",
                    EmailConfirmed = true
                }

                ); ;
        }
    }
}