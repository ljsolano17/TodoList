using Solution.DAL.EF;
using Solution.DO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = Solution.DO.Objects;

namespace Solution.BS
{
    public class Tareas : ICRUD<data.Tareas>
    {
        private SolutionDbContext context;

        public Tareas(SolutionDbContext _context)
        {
            context = _context;
        }
        public void Delete(data.Tareas entity)
        {
            new DAL.Tareas(context).Delete(entity);
        }

        public IEnumerable<data.Tareas> GetAll()
        {
            return new DAL.Tareas(context).GetAll();
        }

        public data.Tareas GetById(int id)
        {
            return new DAL.Tareas(context).GetById(id);
        }

        public void Insert(data.Tareas entity)
        {
            new DAL.Tareas(context).Insert(entity);
        }

        public void Update(data.Tareas entity)
        {
            new DAL.Tareas(context).Update(entity);
        }
    }
}
