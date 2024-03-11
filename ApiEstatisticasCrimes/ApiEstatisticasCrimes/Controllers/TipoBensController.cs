using ApiEstatisticasCrimes.Context;
using ApiEstatisticasCrimes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEstatisticasCrimes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TipoBensController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TipoBensController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TipoBem>> GetAll()
        {
            return _context.TipoBens.AsNoTracking().ToList();
        }

        [HttpGet("{id:int}", Name = "GetByIdTipoBem")]
        public ActionResult<TipoBem> GetById(int id)
        {
            var tipoBem = _context.TipoBens.FirstOrDefault(o => o.TipoBemId == id);

            if (tipoBem == null)
            {
                return NotFound("Tipo de bem não encontrada");
            }

            return tipoBem;
        }

        [HttpPost]
        public ActionResult<TipoBem> Post(TipoBem tipobem)
        {
            _context.TipoBens.Add(tipobem);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetByIdTipoBem", new { id = tipobem.TipoBemId }, tipobem);
        }

        [HttpPut("{id:int}")]
        public ActionResult<TipoBem> Update(TipoBem tipoBem, int id)
        {
            if (tipoBem.TipoBemId != id)
            {
                return BadRequest();
            }
            _context.Entry(tipoBem).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(tipoBem);


        }

        [HttpDelete("{id:int}")]
        public ActionResult<TipoBem> Delete(int id)
        {
            var tipoBem = _context.TipoBens.FirstOrDefault(o => o.TipoBemId == id);

            if (tipoBem == null)
            {
                return NotFound();
            }

            _context.TipoBens.Remove(tipoBem);
            _context.SaveChanges();

            return Ok(tipoBem);

        }
    }
}
