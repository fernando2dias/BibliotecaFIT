using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class UserBookLoanConfiguration : IEntityTypeConfiguration<UserBookLoan>
    {
        public void Configure(EntityTypeBuilder<UserBookLoan> builder)
        {
            builder.HasKey(ub => new { ub.UserId, ub.BookLoanId });
            builder.HasOne(ub => ub.BookLoan).WithMany(l => l.UserBookLoans);
            builder.HasOne(ub => ub.User).WithMany(l => l.UserBookLoans);
        }
    }
}
