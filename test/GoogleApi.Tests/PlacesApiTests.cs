using GoogleApi.Places;
using GoogleApi.Places.Autocomplete.Entities;
using GoogleApi.Places.Autocomplete.ParameterBuilder;
using GoogleApi.Places.Autocomplete.Types;
using GoogleApi.Places.Search;
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
    private readonly GoogleClientSecrets _clientSecrets;

    public PlacesApiTests()
    {
      _clientSecrets = new GoogleClientSecrets(new[] {(PlacesBuilder.ApiName, "API_KEY") });
    }

    [Fact]
    public async void NearbySearch()
    {
      INearbyHttpQueryBuilder searchQueryBuilder =
        PlacesBuilder.Create(_clientSecrets)
          .NearbySearch()
          .Radius(1000)
          .Keyword("bank")
          .Location(42.201154, -85.580002)
          .Language(Languages.English);

      NearbyResult results = await SearchClient.Create().NearbySearch(searchQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Results);
    }

    [Fact]
    public async void TextSearch()
    {
      ITextHttpQueryBuilder textQueryBuilder =
        PlacesBuilder.Create(_clientSecrets)
          .TextSearch()
          .Radius(100)
          .Query("bank")
          .Location(42.201154, -85.580002);

      TextResult results = await SearchClient.Create().TextSearch(textQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Results);
    }

    [Fact]
    public async void RadarSearch()
    {
      IRadarHttpQueryBuilder radarQueryBuilder =
        PlacesBuilder.Create(_clientSecrets)
          .RadarSearch()
          .Radius(1000)
          .Keyword("bank")
          .Location(42.201154, -85.580002);

      RadarResult results = await SearchClient.Create().RadarSearch(radarQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Results);
    }

    [Fact]
    public async void Autocomplete()
    {
      IAutocompleteHttpQueryBuilder autocompleteQueryBuilder =
        PlacesBuilder.Create(_clientSecrets)
          .Autocomplete()
          .Radius(1000)
          .Input("kalamazoo")
          .Types(PlaceTypes.Cities)
          .Location(42.201154, -85.580002);

      AutocompleteResult results = await SearchClient.Create().Autocomplete(autocompleteQueryBuilder);

      Assert.NotNull(results);
      Assert.NotEmpty(results.Predictions);
    }
  }
}