using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BelajarNextJsBackEnd.Entities;
using BelajarNextJsBackEnd.Models.Brand;

namespace BelajarNextJsBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BrandsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Brands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
          if (_context.Brands == null)
          {
              return NotFound();
          }
            return await _context.Brands.ToListAsync();
        }

        // GET: api/Brands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(string id)
        {
          if (_context.Brands == null)
          {
              return NotFound();
          }
            var brand = await _context.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return brand;
        }

        // Post: api/Brands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}", Name = "UpdateBrand")]
        public async Task<IActionResult> PutBrand(string id, BrandUpdateModel brand)
        {
            var update = await _context.Brands.Where(X => X.Id == id).FirstOrDefaultAsync();
            if (update == null)
            {
                return NotFound();
            }

            update.Name = brand.Name;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrandExists(id))
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

        // POST: api/Brands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost(Name = "CreateBrand")]
        public async Task<ActionResult<Brand>> PostBrand(BrandCreateModel brand)
        {
          if (_context.Brands == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Brands'  is null.");
          }

            var insert = new Brand
            {
                Id = Ulid.NewUlid().ToString(),
                Name = brand.Name,
                CreatedAt = DateTimeOffset.UtcNow,
            };

            _context.Brands.Add(insert);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BrandExists(insert.Id))
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

        // DELETE: api/Brands/5
        [HttpDelete("{id}", Name = "DeleteBrand")]
        public async Task<IActionResult> Delete(string id)
        {
            if (_context.Brands == null)
            {
                return NotFound();
            }
            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BrandExists(string id)
        {
            return (_context.Brands?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
