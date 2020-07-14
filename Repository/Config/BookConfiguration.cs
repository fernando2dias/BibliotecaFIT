using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Config
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Author).IsRequired().HasMaxLength(100);
            builder.Property(b => b.BarCode).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Published).IsRequired();
            builder.Property(b => b.QuantityPages).IsRequired();
            

            
        }
    }
}
