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
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<List<ProductDataGridItem>>> GetProducts()
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            return await _context.Products.AsNoTracking().Select(Q => new ProductDataGridItem
            {
                Id = Q.Id,
                Name = Q.Name,
                Description = Q.Description,
                Price = Q.Price,
                Quantity = Q.Quantity,
                BrandName = Q.Brand.Name,
                CreatedAt = Q.CreatedAt,
            }).ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "GetProductDetail")]
        public async Task<ActionResult<ProductDetailModel>> GetProduct(string id)
        {
          if (_context.Products == null)
          {
              return NotFound();
          }
            var product = await _context.Products
                .AsNoTracking()
                .Where(Q => Q.Id == id)
                .Select(Q => new ProductDetailModel
                {
                    Id = Q.Id,
                    Name = Q.Name,
                    Description = Q.Description,
                    Price = Q.Price,
                    Quantity = Q.Quantity,
                    BraindId = Q.BrandId,
                    BrandName = Q.Brand.Name,
                })
                .FirstOrDefaultAsync();

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}", Name = "UpdateProduct")]
        public async Task<IActionResult> PutProduct(string id, ProductUpdateModel product)
        {
            var update = await _context.Products.Where(Q => Q.Id == id).FirstOrDefaultAsync();
            if (update == null)
            {
                return NotFound();
            }
            // Validation
            update.Name = product.Name;
            update.Description = product.Description;
            update.Price = product.Price;
            update.Quantity = product.Quantity;
            update.BrandId = product.BrandId;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost(Name = "CreateProduct")]
        public async Task<ActionResult<Product>> PostProduct(ProductCreateModel product)
        {
          if (_context.Products == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
          }
            // Validation

            var insert = new Product
            {
                Id = Ulid.NewUlid().ToString(),
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity,
                BrandId = product.BrandId,
                CreatedAt = DateTimeOffset.UtcNow,
            };
            _context.Products.Add(insert);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductExists(insert.Id))
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

        // DELETE: api/Products/5
        [HttpDelete("{id}", Name = "DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(string id)
        {
            return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
