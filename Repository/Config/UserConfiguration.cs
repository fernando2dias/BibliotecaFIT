using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Name).IsRequired().HasMaxLength(150);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(50);
            
        }
    }
}
