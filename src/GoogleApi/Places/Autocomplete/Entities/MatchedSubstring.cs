using Newtonsoft.Json;

namespace GoogleApi.Places.Autocomplete.Entities
{
  public class MatchedSubstring
  {
    [JsonProperty("length")]
    public int Length { get; set; }

    [JsonProperty("offset")]
    public int Offset { get; set; }
  }
}