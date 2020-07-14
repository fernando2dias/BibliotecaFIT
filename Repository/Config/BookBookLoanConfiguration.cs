using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class BookBookLoanConfiguration : IEntityTypeConfiguration<BookBookLoan>
    {
        public void Configure(EntityTypeBuilder<BookBookLoan> builder)
        {
            builder.HasKey(bl => new { bl.BookId, bl.BookLoanId });
            builder.HasOne(bl => bl.BookLoan).WithMany(l => l.BookBookLoans);
            builder.HasOne(bl => bl.Book).WithMany(l => l.BookBookLoans);
        }
    }
}
