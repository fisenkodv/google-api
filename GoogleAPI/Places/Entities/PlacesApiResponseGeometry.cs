using Newtonsoft.Json;

namespace GoogleAPI.Places.Entities
{
  public class PlacesApiResponseGeometry
  {
    [JsonProperty( "location" )]
    public PlacesApiLocationPoint Location { get; set; }

    [JsonProperty( "viewport" )]
    public PlacesApiViewPort ViewPort { get; set; }
  }
}