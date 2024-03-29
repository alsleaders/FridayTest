using System.Collections.Generic;
using System.Threading.Tasks;
using fridaytest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fridaytest.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationController : ControllerBase
  {
    private readonly DatabaseContext _context;

    public DestinationController(DatabaseContext context)
    {
      _context = context;
    }

    // GET: api/Destination
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> GetDestination()
    {
      return await _context.Destinations.ToListAsync();
    }


    // GET: api/Destination/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Destination>> GetDestination(int id)
    {
      // var destination = await _context.Destinations.FindAsync(id);
      // Where(i => i.LocationId == LocationId.GetValueOrDefault()).FirstOrDefault(w => w.id == id)

      var destination = await _context.Destinations.Include(i => i.Location).FirstOrDefaultAsync(f => f.Id == id);

      if (destination == null)
      {
        return NotFound();
      }

      return destination;
    }

  }
}