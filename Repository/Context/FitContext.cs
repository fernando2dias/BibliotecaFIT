using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Repository.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Context
{
    public class FitContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }
        public DbSet<User> Users { get; set; }
        
        public FitContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookLoanConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BookBookLoanConfiguration());
            modelBuilder.ApplyConfiguration(new UserBookLoanConfiguration());

            //modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento()
            //{
            //    Id = 1,
            //    Nome = "Boleto",
            //    Descricao = "Forma de Pagamento Boleto"
            //},
            //new FormaPagamento()
            //{
            //    Id = 2,
            //    Nome = "Cartão de Crédito",
            //    Descricao = "Forma de Pagamento Cartão de Crédito"
            //},
            //new FormaPagamento()
            //{
            //    Id = 3,
            //    Nome = "Depósito",
            //    Descricao = "Forma de Pagamento Deposito"
            //}

            //);

            base.OnModelCreating(modelBuilder);
        }

    }
}
