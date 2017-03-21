using System.Threading.Tasks;
using GoogleApi.Places.Autocomplete.Entities;
using GoogleApi.Places.Autocomplete.ParameterBuilder;
using GoogleApi.Places.Search.Entities.Nearby;
using GoogleApi.Places.Search.Entities.Radar;
using GoogleApi.Places.Search.Entities.Text;
using GoogleApi.Places.Search.ParameterBuilder.Interfaces;
using GoogleApi.QueryBuilder;

namespace GoogleApi.Places
{
  public class PlacesClient
  {
    public static Task<NearbyResult> NearbySearch(INearbyHttpQueryBuilder httpQueryBuilder)
    {
      return GetResponse<NearbyResult>(httpQueryBuilder);
    }

    public static Task<TextResult> TextSearch(ITextHttpQueryBuilder httpQueryBuilder)
    {
      return GetResponse<TextResult>(httpQueryBuilder);
    }

    public static Task<RadarResult> RadarSearch(IRadarHttpQueryBuilder httpQueryBuilder)
    {
      return GetResponse<RadarResult>(httpQueryBuilder);
    }

    public static Task<AutocompleteResult> Autocomplete(IAutocompleteHttpQueryBuilder httpQueryBuilder)
    {
      return GetResponse<AutocompleteResult>(httpQueryBuilder);
    }

    private static Task<T> GetResponse<T>(IHttpQueryBuilder httpQueryBuilder)
    {
      var apiClient = new ApiClient();
      return apiClient.GetResponse<T>(httpQueryBuilder.Build());
    }
  }
}