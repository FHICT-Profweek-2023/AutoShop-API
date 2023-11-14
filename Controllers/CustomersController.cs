using AutoShop_API.Data;
using AutoShop_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerContext _context;

        public CustomersController(CustomerContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Customer>> GetCustomers(int id)
        {
            var Customers = await _context.Customers.FindAsync(id);

            if (Customers == null)
            {
                return NotFound();
            }

            return Customers;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomers(int id, Customer Customers)
        {
            if (id != Customers.Id)
            {
                return BadRequest();
            }

            _context.Entry(Customers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomersExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomers(Customer Customers)
        {
            if (_context.Customers == null)
            {
                return Problem("Entity set 'CustomersContext.Customers' is null.");
            }
            _context.Customers.Add(Customers);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomers), new { id = Customers.Id }, Customers);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomers(int id)
        {
            if (_context.Customers == null)
            {
                return NotFound();
            }
            var Customers = await _context.Customers.FindAsync(id);
            if (Customers == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(Customers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomersExists(int id)
        {
            return (_context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
