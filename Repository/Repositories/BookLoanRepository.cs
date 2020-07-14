using Domain.Contracts;
using Domain.Entity;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class BookLoanRepository : BaseRepository<BookLoan>, IBookLoanRepository
    {
        public BookLoanRepository(FitContext fitContext) : base(fitContext)
        {
        }
    }
}
