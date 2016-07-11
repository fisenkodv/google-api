using Newtonsoft.Json;

namespace GoogleAPI.Places.Entities
{
  public class PlacesApiLocationPoint
  {

    [JsonProperty( "lat" )]
    public double Langitude { get; set; }

    [JsonProperty( "lng" )]
    public double Longitude { get; set; }
  }
}