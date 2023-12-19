using AutoShop_API.Data;
using AutoShop_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ControlsController : ControllerBase
{
    private readonly ControlContext _context;

    public ControlsController(ControlContext context)
    {
        _context = context;
    }

    // GET: api/Controls
    /*[HttpGet]
    public async Task<ActionResult<IEnumerable<Controls>>> GetControls()
    {
        return await _context.Controls.ToListAsync();
    }*/

    // GET: api/Controls/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Control>> GetControls(int id)
    {
        var controls = await _context.Controls.FindAsync(id);

        if (controls == null)
        {
            return NotFound();
        }

        return controls;
    }

    // PUT: api/Controls/5
    // To protect from over-posting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id:int}")]
    public async Task<IActionResult> PutControls(int id, Control credentialses)
    {
        if (id != credentialses.Id)
        {
            return BadRequest();
        }

        _context.Entry(credentialses).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ControlsExists(id))
            {
                return NotFound();
            }

            throw;
        }

        return NoContent();
    }

    // POST: api/Controls
    // To protect from over-posting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Control>> PostControls(Control credentialses)
    {
        _context.Controls.Add(credentialses);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetControls), new { id = credentialses.Id }, credentialses);
    }

    // DELETE: api/Controls/5
    /*[HttpDelete("{id}")]
    public async Task<IActionResult> DeleteControls(int id)
    {
        if (_context.Controls == null)
        {
            return NotFound();
        }
        var Controls = await _context.Controls.FindAsync(id);
        if (Controls == null)
        {
            return NotFound();
        }

        _context.Controls.Remove(Controls);
        await _context.SaveChangesAsync();

        return NoContent();
    }*/

    private bool ControlsExists(int id)
    {
        return _context.Controls.Any(e => e.Id == id);
    }
}