using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BelajarNextJsBackEnd.Entities;
using BelajarNextJsBackEnd.Models.Province;

namespace BelajarNextJsBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProvincesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Provinces
        [HttpGet]
        public async Task<ActionResult<List<Province>>> GetProvinces(string? search)
        {
            if (_context.Provinces == null)
            {
                return NotFound();
            }

            var query = _context.Provinces.AsNoTracking();

            if (string.IsNullOrEmpty(search))
            {
                return await query.ToListAsync();
            }

            return await query
                .Where(Q => Q.Name.ToLower().Contains(search.ToLower()))      // <-- don't do this at real project
                // LIKE %search%
                .ToListAsync();
        }

        // GET: api/Provinces/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Province>> GetProvince(string id)
        {
            if (_context.Provinces == null)
            {
                return NotFound();
            }
            var province = await _context.Provinces.FindAsync(id);

            if (province == null)
            {
                return NotFound();
            }

            return province;
        }

        // PUT: api/Provinces/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}", Name = "UpdateProvince")]
        public async Task<IActionResult> Post(string id, ProvinceUpdateModel province)
        {
            var update = await _context.Provinces.Where(Q => Q.Id == id).FirstOrDefaultAsync();
            if (update == null)
            {
                return NotFound();
            }

            // ada validasi namenya
            update.Name = province.Name;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinceExists(id))
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

        // POST: api/Provinces
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost(Name = "CreateProvince")]
        public async Task<ActionResult<Province>> Post(ProvinceCreateModel province)
        {
            if (_context.Provinces == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Provinces'  is null.");
            }

            // ada validasinya dulu pake fluentvalidation

            var insert = new Province
            {
                Id = Ulid.NewUlid().ToString(),
                Name = province.Name,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            _context.Provinces.Add(insert);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProvinceExists(insert.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return insert;
        }

        // DELETE: api/Provinces/5
        [HttpDelete("{id}", Name = "DeleteProvince")]
        public async Task<IActionResult> Delete(string id)
        {
            if (_context.Provinces == null)
            {
                return NotFound();
            }
            var province = await _context.Provinces.FindAsync(id);
            if (province == null)
            {
                return NotFound();
            }

            _context.Provinces.Remove(province);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProvinceExists(string id)
        {
            return (_context.Provinces?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
