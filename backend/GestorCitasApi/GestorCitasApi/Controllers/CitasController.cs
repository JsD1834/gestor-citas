using GestorCitasApi.Context;
using GestorCitasApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestorCitasApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CitasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var citas = await _context.Citas.Include(c => c.Usuario).ToListAsync();
            return Ok(citas);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Cita cita)
        {
            _context.Citas.Add(cita);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = cita.Id }, cita);
        }
    }
}
