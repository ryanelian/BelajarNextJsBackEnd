using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BelajarNextJsBackEnd.Entities;
using BelajarNextJsBackEnd.Models;

namespace BelajarNextJsBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<List<CityDataGridItem>>> GetCities()
        {
            if (_context.Cities == null)
            {
                return NotFound();
            }
            return await _context.Cities.AsNoTracking().Select(Q => new CityDataGridItem
            {
                Id = Q.Id,
                Name = Q.Name,
                ProvinceName = Q.Province.Name,
                CreatedAt = Q.CreatedAt,
            }).ToListAsync();
        }

        // GET: api/Cities/5
        [HttpGet("{id}", Name = "GetCityDetail")]
        public async Task<ActionResult<CityDetailModel>> GetCity(string id)
        {
            if (_context.Cities == null)
            {
                return NotFound();
            }

            var city = await _context.Cities
                .AsNoTracking()
                .Where(Q => Q.Id == id)
                .Select(Q => new CityDetailModel
                {
                    Id = Q.Id,
                    Name = Q.Name,
                    ProvinceId = Q.ProvinceId,
                    ProvinceName = Q.Province.Name,
                })
                .FirstOrDefaultAsync();

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}", Name = "UpdateCity")]
        public async Task<IActionResult> Post(string id, CityUpdateModel city)
        {
            var update = await _context.Cities.Where(Q => Q.Id == id).FirstOrDefaultAsync();
            if (update == null)
            {
                return NotFound();
            }

            update.Name = city.Name;
            update.ProvinceId = city.ProvinceId;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
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

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost(Name = "CreateCity")]
        public async Task<ActionResult<City>> Post(CityCreateModel city)
        {
            if (_context.Cities == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cities'  is null.");
            }

            // harus ada validasinya...

            var insert = new City
            {
                Id = Ulid.NewUlid().ToString(),
                Name = city.Name,
                ProvinceId = city.ProvinceId,
                CreatedAt = DateTimeOffset.UtcNow,
            };

            _context.Cities.Add(insert);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CityExists(insert.Id))
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

        // DELETE: api/Cities/5
        [HttpDelete("{id}", Name = "DeleteCity")]
        public async Task<IActionResult> DeleteCity(string id)
        {
            if (_context.Cities == null)
            {
                return NotFound();
            }
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CityExists(string id)
        {
            return (_context.Cities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
