using Domain.Contracts;
using Domain.Entity;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(FitContext fitContext) : base(fitContext)
        {
        }
    }
}
