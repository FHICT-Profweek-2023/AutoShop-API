using AutoShop_API.Data;
using AutoShop_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CredentialsController : ControllerBase
{
    private readonly CredentialContext _context;

    public CredentialsController(CredentialContext context)
    {
        _context = context;
    }

    // GET: api/Credential
    /*[HttpGet]
    public async Task<ActionResult<IEnumerable<Credential>>> GetCredentials()
    {
        return await _context.Credential.ToListAsync();
    }*/

    // GET: api/Credential/5
    [HttpGet("{username}")]
    public async Task<ActionResult<Credential>> GetCredentials(string username)
    {
        try
        {
            var user = await _context.Credentials.FirstAsync(c => c.username == username);
            var credentials = await _context.Credentials.FindAsync(user.Id);

            return credentials == null ? NotFound() : credentials;
        }
        catch (InvalidOperationException)
        {
            return NotFound();
        }
    }

    // PUT: api/Credential/5
    // To protect from over-posting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    /*[HttpPut("{id:int}")]
    public async Task<IActionResult> PutCredentials(int id, Credential credential)
    {
        if (id != credential.Id)
        {
            return BadRequest();
        }

        _context.Entry(credential).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CredentialsExists(id))
            {
                return NotFound();
            }

            throw;
        }

        return NoContent();
    }*/

    // POST: api/Credential
    // To protect from over-posting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Credential>> PostCredentials(Credential credential)
    {
        _context.Credentials.Add(credential);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetCredentials), new { id = credential.Id }, credential);
    }

    // DELETE: api/Credential/5
    /*[HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCredentials(int id)
    {
        if (_context.Credential == null)
        {
            return NotFound();
        }
        var Credential = await _context.Credential.FindAsync(id);
        if (Credential == null)
        {
            return NotFound();
        }

        _context.Credential.Remove(Credential);
        await _context.SaveChangesAsync();

        return NoContent();
    }*/

    /*private bool CredentialsExists(int id)
    {
        return _context.Credentials.Any(e => e.Id == id);
    }*/
}