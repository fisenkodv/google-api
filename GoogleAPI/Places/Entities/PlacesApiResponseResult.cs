using Newtonsoft.Json;

namespace GoogleAPI.Places.Entities
{
  public class PlacesApiResponseResult
  {
    [JsonProperty( "geometry" )]
    public PlacesApiResponseGeometry Geometry { get; set; }

    [JsonProperty( "icon" )]
    public string Icon { get; set; }

    [JsonProperty( "id" )]
    public string Id { get; set; }

    [JsonProperty( "name" )]
    public string Name { get; set; }

    [JsonProperty( "photos" )]
    public PlacesApiResponsePhoto[] Photos { get; set; }

    [JsonProperty( "place_id" )]
    public string PlaceId { get; set; }

    [JsonProperty( "price_level" )]
    public int PriceLevel { get; set; }

    [JsonProperty( "rating" )]
    public float Rating { get; set; }

    [JsonProperty( "reference" )]
    public string Reference { get; set; }

    [JsonProperty( "scope" )]
    public string Scope { get; set; }

    [JsonProperty( "types" )]
    public string[] Types { get; set; }

    [JsonProperty( "vicinity" )]
    public string Vicinity { get; set; }
  }
}