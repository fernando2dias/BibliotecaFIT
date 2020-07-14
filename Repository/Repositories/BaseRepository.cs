using Domain.Contracts;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly FitContext FitContext;
        public BaseRepository(FitContext fitContext)
        {
            FitContext = fitContext;
        }

        public void Add(TEntity entity)
        {
            FitContext.Set<TEntity>().Add(entity);
            FitContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            FitContext.Set<TEntity>().Update(entity);
            FitContext.SaveChanges();
        }


        public TEntity GetById(int id)
        {
            return FitContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return FitContext.Set<TEntity>().ToList();
        }

        public void Delete(TEntity entity)
        {
            FitContext.Remove(entity);
            FitContext.SaveChanges();
        }

        public void Dispose()
        {
            FitContext.Dispose();
        }

    }
}
