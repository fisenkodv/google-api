using Newtonsoft.Json;

namespace GoogleApi.Places.Search.Entities.Common
{
  public class LocationPoint
  {

    [JsonProperty( "lat" )]
    public double Langitude { get; set; }

    [JsonProperty( "lng" )]
    public double Longitude { get; set; }
  }
}