using System.Collections.Generic;

namespace fridaytest.Model
{
  public class Location
  {
    public int Id { get; set; }
    public string Place { get; set; }
    public float Long { get; set; }
    public float Lat { get; set; }
    public bool Visited { get; set; }

    public List<fridaytest.Model.Destination> Destinations { get; set; } = new List<Destination>();


  }
}