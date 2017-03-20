using GoogleApi.Places.Autocomplete.ParameterBuilder;
using GoogleApi.Places.Search.ParameterBuilder.Interfaces;
using GoogleApi.Places.Search.ParameterBuilder.QueryBuilder;

namespace GoogleApi.Places
{
  public class PlacesBuilder : IPlacesBuilder
  {
    public const string ApiName = "GooglePlacesApi";

    private readonly string _apiKey;

    private PlacesBuilder(GoogleClientSecrets clientSecrets)
    {
      _apiKey = GetApiKey(clientSecrets);
    }

    public static PlacesBuilder Create(GoogleClientSecrets clientSecrets)
    {
      return new PlacesBuilder(clientSecrets);
    }

    public INearbyHttpQueryBuilder NearbySearch()
    {
      return new NearbyHttpQueryBuilder(_apiKey);
    }

    public ITextHttpQueryBuilder TextSearch()
    {
      return new TextHttpQueryBuilder(_apiKey);
    }

    public IRadarHttpQueryBuilder RadarSearch()
    {
      return new RadarHttpQueryBuilder(_apiKey);
    }

    public IAutocompleteHttpQueryBuilder Autocomplete()
    {
      return new AutocompleteHttpQueryBuilder(_apiKey);
    }

    private static string GetApiKey(GoogleClientSecrets clientSecrets)
    {
      return clientSecrets[ApiName];
    }
  }
}