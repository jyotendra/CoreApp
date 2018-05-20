using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string CountryCode { get; set; }

        public string Mobile { get; set; }

        public UserProfile UserProfile { get; set; }

    }

    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            // Field level constraints
            user.Property(u => u.Email).HasMaxLength(40).IsRequired();
            user.Property(u => u.CountryCode).HasMaxLength(5).IsRequired();
            user.Property(u => u.Mobile).HasMaxLength(15).IsRequired();

            user.HasIndex(u => new { u.CountryCode, u.Mobile }).IsUnique();

        }
    }
}



