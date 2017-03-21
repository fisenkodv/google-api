using GoogleApi.Places;
using GoogleApi.Places.Autocomplete.Entities;
using GoogleApi.Places.Autocomplete.ParameterBuilder;
using GoogleApi.Places.Autocomplete.Types;
using GoogleApi.Places.Search.Entities.Nearby;
using GoogleApi.Places.Search.Entities.Radar;
using GoogleApi.Places.Search.Entities.Text;
using GoogleApi.Places.Search.ParameterBuilder.Interfaces;
using GoogleApi.Places.Types;
using Xunit;

namespace GoogleApi.Tests
{
  public class PlacesApiTests
  {
    [Fact]
    public async void NearbySearch()
    {
      INearbyHttpQueryBuilder searchQueryBuilder =
        PlacesBuilder.Create(GoogleClientSecretsStorage.Instance.ClientSecrets)
          .NearbySearch()
          .Radius(1000)
          .Keyword("bank")
          .Location(42.201154, -85.580002)
          .Language(Languages.English);

      NearbyResult results = await PlacesClient.NearbySearch(searchQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Results);
    }

    [Fact]
    public async void TextSearch()
    {
      ITextHttpQueryBuilder textQueryBuilder =
        PlacesBuilder.Create(GoogleClientSecretsStorage.Instance.ClientSecrets)
          .TextSearch()
          .Radius(100)
          .Query("bank")
          .Location(42.201154, -85.580002);

      TextResult results = await PlacesClient.TextSearch(textQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Results);
    }

    [Fact]
    public async void RadarSearch()
    {
      IRadarHttpQueryBuilder radarQueryBuilder =
        PlacesBuilder.Create(GoogleClientSecretsStorage.Instance.ClientSecrets)
          .RadarSearch()
          .Radius(1000)
          .Keyword("bank")
          .Location(42.201154, -85.580002);

      RadarResult results = await PlacesClient.RadarSearch(radarQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Results);
    }

    [Fact]
    public async void Autocomplete()
    {
      IAutocompleteHttpQueryBuilder autocompleteQueryBuilder =
        PlacesBuilder.Create(GoogleClientSecretsStorage.Instance.ClientSecrets)
          .Autocomplete()
          .Radius(1000)
          .Input("kalamazoo")
          .Types(PlaceTypes.Cities)
          .Location(42.201154, -85.580002);

      AutocompleteResult results = await PlacesClient.Autocomplete(autocompleteQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Predictions);
    }
  }
}