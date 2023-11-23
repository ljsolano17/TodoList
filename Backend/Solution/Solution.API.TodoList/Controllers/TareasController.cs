using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solution.DAL.EF;
using data = Solution.DO.Objects;
using datamodels = Solution.API.TodoList.datamodels;

namespace Solution.API.TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly SolutionDbContext _context;
        private readonly IMapper _mapper;

        public TareasController(SolutionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Tareas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<datamodels.Tareas>>> GetTareas()
        {
            var aux = new BS.Tareas(_context).GetAll();
            var map = _mapper.Map<IEnumerable<data.Tareas>, IEnumerable<datamodels.Tareas>>(aux).ToList();
            return map;
        }

        // GET: api/Tareas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<datamodels.Tareas>> GetTarea(int id)
        {
           
            var tarea = new BS.Tareas(_context).GetById(id);

            if (tarea == null)
            {
                return NotFound();
            }
            var map = _mapper.Map<data.Tareas, datamodels.Tareas>(tarea);
            return map;
        }

        // PUT: api/Tareas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarea(int id, datamodels.Tareas tarea)
        {
            if (id != tarea.Id)
            {
                return BadRequest();
            }

            try
            {
                var map = _mapper.Map<datamodels.Tareas, data.Tareas>(tarea);
                new BS.Tareas(_context).Update(map);
            }
            catch (Exception ex)
            {
                if (!TareaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tareas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<datamodels.Tareas>> PostTarea(datamodels.Tareas tarea)
        {
            var map = _mapper.Map<datamodels.Tareas, data.Tareas>(tarea);
            new BS.Tareas(_context).Insert(map);

            return CreatedAtAction("GetTarea", new { id = tarea.Id }, tarea);
        }

        // DELETE: api/Tareas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<datamodels.Tareas>> DeleteTarea(int id)
        {
           
            var tarea = new BS.Tareas(_context).GetById(id);
            if (tarea == null)
            {
                return NotFound();
            }

            new BS.Tareas(_context).Delete(tarea);
            var map = _mapper.Map<data.Tareas,datamodels.Tareas>(tarea);

            return map;
        }

        private bool TareaExists(int id)
        {
            return (new BS.Tareas(_context).GetById(id)!=null);
        }
    }
}
