using ApiEstatisticasCrimes.Context;
using ApiEstatisticasCrimes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEstatisticasCrimes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ZonasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ZonasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Zona>> GetAll()
        {
            return _context.Zonas.AsNoTracking().ToList();
        }

        [HttpGet("{id:int}", Name = "GetByIdZonas")]
        public ActionResult<Zona> GetById(int id)
        {
            var zona = _context.Zonas.FirstOrDefault(o => o.ZonaId == id);

            if (zona == null)
            {
                return NotFound("Zona não encontrada");
            }

            return zona;
        }

        [HttpPost]
        public ActionResult<Zona> Post(Zona zona)
        {
            _context.Zonas.Add(zona);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetByIdZona", new { id = zona.ZonaId }, zona);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Zona> Update(Zona zona, int id)
        {
            if (zona.ZonaId != id)
            {
                return BadRequest();
            }
            _context.Entry(zona).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(zona);


        }

        [HttpDelete("{id:int}")]
        public ActionResult<Zona> Delete(int id)
        {
            var zona = _context.Zonas.FirstOrDefault(o => o.ZonaId == id);

            if (zona == null)
            {
                return NotFound();
            }

            _context.Zonas.Remove(zona);
            _context.SaveChanges();

            return Ok(zona);

        }
    }
}
