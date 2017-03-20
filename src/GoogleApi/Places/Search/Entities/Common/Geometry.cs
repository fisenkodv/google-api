using Newtonsoft.Json;

namespace GoogleApi.Places.Search.Entities.Common
{
  public class Geometry
  {
    [JsonProperty( "location" )]
    public LocationPoint Location { get; set; }

    [JsonProperty( "viewport" )]
    public ViewPort ViewPort { get; set; }
  }
}