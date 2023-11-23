using Solution.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly SolutionDbContext dbContext;

        public Repository(SolutionDbContext context)
        {
            dbContext = context;
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            try
            {
                dbContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetOneById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            if(dbContext.Entry<T>(entity).State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {
                dbContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            }
            else
            {
                dbContext.Set<T>().Add(entity);
            }
        }

        public void Update(T entity)
        {
            dbContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
