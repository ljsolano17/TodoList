using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetOneById(int id);
        void Update(T entity);
        void Delete(T entity);
        void Insert(T entity);
        void Commit();
    }
}
