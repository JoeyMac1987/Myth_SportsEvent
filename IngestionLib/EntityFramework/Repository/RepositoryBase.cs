using IngestionLib.EntityFramework.DAL;
using IngestionLib.EntityFramework.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;


namespace IngestionLib.EntityFramework.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        internal iSportsEventDBContext _context;
        internal DbSet<TEntity> dbSet;
        public iSportsEventDBContext Context { get; set; }

        protected SportsEventDBContext SportsEventDBContext { get; set; }

        public RepositoryBase(SportsEventDBContext context)
        {
            _context = context;
            this.SportsEventDBContext = context;
            this.dbSet = context.Set<TEntity>();
            Context = _context;
        }


        public IQueryable<TEntity> FindAll()
        {
            return this.SportsEventDBContext.Set<TEntity>().AsNoTracking();
        }

        public void Create(TEntity entity)
        {
            this.SportsEventDBContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            this.SportsEventDBContext.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this.SportsEventDBContext.Set<TEntity>().Remove(entity);
        }

        public TEntity FindById(object id)
        {
            return dbSet.Find(id);
        }

        public TEntity FindById(object id, params Expression<Func<TEntity, object>>[] includes)
        {
            if (includes.Any())
            {
                foreach (var include in includes)
                {
                    dbSet.Include(include);
                }
            }

            return dbSet.Find(id);

        }


        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includes.Any())
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }

            return query;
        }



    }
}
