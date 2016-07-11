using Newtonsoft.Json;

namespace GoogleAPI.Places.Entities
{
  public class PlacesApiViewPort
  {
    [JsonProperty( "northeast" )]
    public PlacesApiLocationPoint NorthEast { get; set; }

    [JsonProperty( "southwest" )]
    public PlacesApiLocationPoint SouthWest { get; set; }
  }
}