using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BelajarNextJsBackEnd.Entities;

namespace BelajarNextJsBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderStatusController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PurchaseOrderStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PurchaseOrderStatus>>> GetPurchaseOrderStatuses()
        {
          if (_context.PurchaseOrderStatuses == null)
          {
              return NotFound();
          }
            return await _context.PurchaseOrderStatuses.ToListAsync();
        }

        // GET: api/PurchaseOrderStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PurchaseOrderStatus>> GetPurchaseOrderStatus(string id)
        {
          if (_context.PurchaseOrderStatuses == null)
          {
              return NotFound();
          }
            var purchaseOrderStatus = await _context.PurchaseOrderStatuses.FindAsync(id);

            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }

            return purchaseOrderStatus;
        }

        // PUT: api/PurchaseOrderStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderStatus(string id, PurchaseOrderStatus purchaseOrderStatus)
        {
            if (id != purchaseOrderStatus.Id)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderStatusExists(id))
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

        // POST: api/PurchaseOrderStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PurchaseOrderStatus>> PostPurchaseOrderStatus(PurchaseOrderStatus purchaseOrderStatus)
        {
          if (_context.PurchaseOrderStatuses == null)
          {
              return Problem("Entity set 'ApplicationDbContext.PurchaseOrderStatuses'  is null.");
          }
            _context.PurchaseOrderStatuses.Add(purchaseOrderStatus);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PurchaseOrderStatusExists(purchaseOrderStatus.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPurchaseOrderStatus", new { id = purchaseOrderStatus.Id }, purchaseOrderStatus);
        }

        // DELETE: api/PurchaseOrderStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrderStatus(string id)
        {
            if (_context.PurchaseOrderStatuses == null)
            {
                return NotFound();
            }
            var purchaseOrderStatus = await _context.PurchaseOrderStatuses.FindAsync(id);
            if (purchaseOrderStatus == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderStatuses.Remove(purchaseOrderStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PurchaseOrderStatusExists(string id)
        {
            return (_context.PurchaseOrderStatuses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
