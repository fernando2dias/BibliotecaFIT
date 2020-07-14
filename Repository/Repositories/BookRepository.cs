using Domain.Contracts;
using Domain.Entity;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(FitContext fitContext) : base(fitContext)
        {
        }
    }
}
