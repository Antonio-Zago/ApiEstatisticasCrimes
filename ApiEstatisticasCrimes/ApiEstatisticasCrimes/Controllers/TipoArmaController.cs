using ApiEstatisticasCrimes.Context;
using ApiEstatisticasCrimes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEstatisticasCrimes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoArmaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoArmaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoArma>> GetAll()
        {
            return _context.TipoArmas.AsNoTracking().ToList();
        }

        [HttpGet("{id:int}", Name = "GetByIdTipoArmas")]
        public ActionResult<TipoArma> GetById(int id)
        {
            var tipoArma = _context.TipoArmas.FirstOrDefault(o => o.TipoArmaId == id);

            if (tipoArma == null)
            {
                return NotFound("Tipo de arma não encontrada");
            }

            return tipoArma;
        }

        [HttpPost]
        public ActionResult<Ocorrencia> Post(TipoArma tipoArma)
        {
            _context.TipoArmas.Add(tipoArma);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetByIdTipoArmas", new { id = tipoArma.TipoArmaId }, tipoArma);
        }

        [HttpPut("{id:int}")]
        public ActionResult<TipoArma> Update(TipoArma tipoArma, int id)
        {
            if (tipoArma.TipoArmaId != id)
            {
                return BadRequest();
            }
            _context.Entry(tipoArma).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(tipoArma);


        }

        [HttpDelete("{id:int}")]
        public ActionResult<TipoArma> Delete(int id)
        {
            var tipoArma = _context.TipoArmas.FirstOrDefault(o => o.TipoArmaId == id);

            if (tipoArma == null)
            {
                return NotFound();
            }

            _context.TipoArmas.Remove(tipoArma);
            _context.SaveChanges();

            return Ok(tipoArma);

        }
    }
}
