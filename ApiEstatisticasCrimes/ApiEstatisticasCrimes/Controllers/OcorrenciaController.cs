using ApiEstatisticasCrimes.Context;
using ApiEstatisticasCrimes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEstatisticasCrimes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OcorrenciaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OcorrenciaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Ocorrencia>> GetAll()
        {
            return _context.Ocorrencias.AsNoTracking().ToList();
        }

        [HttpGet("{id:int}",  Name = "GetByIdOcorrencias")]
        public ActionResult<Ocorrencia> GetById(int id)
        {
            var ocorrencia = _context.Ocorrencias.FirstOrDefault(o=>o.OcorrenciaId == id);

            if (ocorrencia == null)
            {
                return NotFound("Produto não encontrado");
            }

            return ocorrencia;
        }

        [HttpPost]
        public ActionResult<Ocorrencia> Post(Ocorrencia ocorrencia)
        {
            _context.Ocorrencias.Add(ocorrencia);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetByIdOcorrencias", new { id = ocorrencia.OcorrenciaId}, ocorrencia);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Ocorrencia> Update(Ocorrencia ocorrencia, int id) 
        {
            if (ocorrencia.OcorrenciaId != id)
            {
                return BadRequest();
            }
            _context.Entry(ocorrencia).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(ocorrencia);


        }

        [HttpDelete("{id:int}")]
        public ActionResult<Ocorrencia> Delete(int id)
        {
            var ocorrencia = _context.Ocorrencias.FirstOrDefault(o => o.OcorrenciaId == id);

            if (ocorrencia == null)
            {
                return NotFound();
            }

            _context.Ocorrencias.Remove(ocorrencia);
            _context.SaveChanges();

            return Ok(ocorrencia);

        }
    }
}
