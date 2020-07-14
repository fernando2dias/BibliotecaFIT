using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class BookLoanConfiguration : IEntityTypeConfiguration<BookLoan>
    {
        public void Configure(EntityTypeBuilder<BookLoan> builder)
        {
            builder.HasKey(b => b.Id);

            
            builder.Property(b => b.LoanDate).IsRequired();
            builder.Property(b => b.ReturnDate).IsRequired();
            
        }
    }
}
