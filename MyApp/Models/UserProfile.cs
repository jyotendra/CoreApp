using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }

        public int UserId { get; set; }

        public string FullName { get; set; }

        public string MyProperty { get; set; }

        public User User { get; set; }

    }


    public class UserProfileEntityConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> userProfile)
        {
            userProfile.HasOne(up => up.User)
                .WithOne(u => u.UserProfile)
                .HasForeignKey<UserProfile>(up => up.UserId);


        }
    }
}
