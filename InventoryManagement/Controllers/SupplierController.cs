﻿using InventoryPOS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers
{
    public class SupplierController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class SuppliersController : ControllerBase
        {
            private readonly AppDbContext _context;

            public SuppliersController(AppDbContext context)
            {
                _context = context;
            }

            // GET: api/Suppliers
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Supplier>>> GetSupplier()
            {
                return await _context.Suppliers.ToListAsync();
            }

            // GET: api/Suppliers/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Supplier>> GetSupplier(int id)
            {
                var supplier = await _context.Suppliers.FindAsync(id);

                if (supplier == null)
                {
                    return NotFound();
                }

                return supplier;
            }

            // PUT: api/Suppliers/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutSupplier(int id, Supplier supplier)
            {
                if (id != supplier.SupplierID)
                {
                    return BadRequest();
                }

                _context.Entry(supplier).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierExists(id))
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

            // POST: api/Suppliers
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
            {
                _context.Suppliers.Add(supplier);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetSupplier", new { id = supplier.SupplierID }, supplier);
            }

            // DELETE: api/Suppliers/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteSupplier(int id)
            {
                var supplier = await _context.Suppliers.FindAsync(id);
                if (supplier == null)
                {
                    return NotFound();
                }

                _context.Suppliers.Remove(supplier);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool SupplierExists(int id)
            {
                return _context.Suppliers.Any(e => e.SupplierID == id);
            }
        }
    }
}

