using Newtonsoft.Json;

namespace GoogleAPI.Places.Entities
{
  public class PlacesApiResponse
  {
    [JsonProperty( "next_page_token" )]
    public string NextPageToken { get; set; }

    [JsonProperty( "results" )]
    public PlacesApiResponseResult[] Results { get; set; }

    [JsonProperty( "status" )]
    public string Status { get; set; }
  }
}