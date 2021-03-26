using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BugetApi.Data;
using BugetApi.Model;

namespace BugetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheltuialasController : ControllerBase
    {
        private readonly DataContext _context;

        public CheltuialasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Cheltuialas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cheltuiala>>> GetCheltuialas()
        {
            return await _context.Cheltuialas.ToListAsync();
        }

        // GET: api/Cheltuialas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cheltuiala>> GetCheltuiala(int id)
        {
            var cheltuiala = await _context.Cheltuialas.FindAsync(id);

            if (cheltuiala == null)
            {
                return NotFound();
            }

            return cheltuiala;
        }

        // PUT: api/Cheltuialas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheltuiala(int id, Cheltuiala cheltuiala)
        {
            if (id != cheltuiala.CheltuialaId)
            {
                return BadRequest();
            }

            _context.Entry(cheltuiala).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheltuialaExists(id))
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

        // POST: api/Cheltuialas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cheltuiala>> PostCheltuiala(Cheltuiala cheltuiala)
        {
            _context.Cheltuialas.Add(cheltuiala);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheltuiala", new { id = cheltuiala.CheltuialaId }, cheltuiala);
        }

        // DELETE: api/Cheltuialas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCheltuiala(int id)
        {
            var cheltuiala = await _context.Cheltuialas.FindAsync(id);
            if (cheltuiala == null)
            {
                return NotFound();
            }

            _context.Cheltuialas.Remove(cheltuiala);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CheltuialaExists(int id)
        {
            return _context.Cheltuialas.Any(e => e.CheltuialaId == id);
        }
    }
}
