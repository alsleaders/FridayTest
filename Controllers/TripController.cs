using System.Collections.Generic;
using System.Threading.Tasks;
using fridaytest.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fridaytest.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class TripController : ControllerBase
  {
    private readonly DatabaseContext _context;

    public TripController(DatabaseContext context)
    {
      _context = context;
    }

    // GET: api/Location
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Trip>>> GetTrips()
    {
      return await _context.Trips.ToListAsync();
    }


    [HttpPost]
    public async Task<ActionResult<Trip>> PostTrip(Trip trip)
    {
      _context.Trips.Add(trip);
      await _context.SaveChangesAsync();

      return CreatedAtAction("GetTrip", new { id = trip.Id }, trip);
    }

  }
}