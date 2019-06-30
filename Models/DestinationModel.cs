using System.Collections.Generic;

namespace fridaytest.Model
{
  public class Destination
  {
    public int Id { get; set; }



    public int? TripId { get; set; }
    public Trip Trip { get; set; }

    public List<fridaytest.Model.Location> Location { get; set; } = new List<Location>();
  }
}