namespace fridaytest.Model
{
  public class Location
  {
    public int Id { get; set; }
    public string Place { get; set; }
    public float Long { get; set; }
    public float Lat { get; set; }
    public bool Visited { get; set; }


    public int? DestinationId { get; set; }
    public Destination Destination { get; set; }
  }
}