using Solution.DAL.EF;
using Solution.DAL.Repository;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DO.Objects;

namespace Solution.DAL
{
    public class Tareas : ICRUD<data.Tareas>
    {
        private Repository<data.Tareas> _repo = null;

        public Tareas(SolutionDbContext context)
        {
            _repo = new Repository<data.Tareas>(context);
        }

        public void Delete(data.Tareas entity)
        {
            _repo.Delete(entity);
            _repo.Commit();
        }

        public IEnumerable<data.Tareas> GetAll()
        {
            return _repo.GetAll();
        }

        public data.Tareas GetById(int id)
        {
            return _repo.GetOneById(id);
        }

        public void Insert(data.Tareas entity)
        {
            _repo.Insert(entity);
            _repo.Commit();
        }

        public void Update(data.Tareas entity)
        {
            _repo.Update(entity);
            _repo.Commit();
        }
    }
}
