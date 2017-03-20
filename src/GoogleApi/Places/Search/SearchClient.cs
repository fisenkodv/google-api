using System.Threading.Tasks;
using GoogleApi.Places.Autocomplete.Entities;
using GoogleApi.Places.Autocomplete.ParameterBuilder;
using GoogleApi.Places.Search.Entities.Nearby;
using GoogleApi.Places.Search.Entities.Radar;
using GoogleApi.Places.Search.Entities.Text;
using GoogleApi.Places.Search.ParameterBuilder.Interfaces;

namespace GoogleApi.Places.Search
{
  public class SearchClient
  {
    private readonly ApiClient _apiClient;

    private SearchClient()
    {
      _apiClient = new ApiClient();
    }

    public static SearchClient Create()
    {
      return new SearchClient();
    }

    public Task<NearbyResult> NearbySearch(INearbyHttpQueryBuilder httpQueryBuilder)
    {
      return _apiClient.GetResponse<NearbyResult>(httpQueryBuilder.Build());
    }

    public Task<TextResult> TextSearch(ITextHttpQueryBuilder httpQueryBuilder)
    {
      return _apiClient.GetResponse<TextResult>(httpQueryBuilder.Build());
    }

    public Task<RadarResult> RadarSearch(IRadarHttpQueryBuilder httpQueryBuilder)
    {
      return _apiClient.GetResponse<RadarResult>(httpQueryBuilder.Build());
    }

    public Task<AutocompleteResult> Autocomplete(IAutocompleteHttpQueryBuilder httpQueryBuilder)
    {
      return _apiClient.GetResponse<AutocompleteResult>(httpQueryBuilder.Build());
    }
  }
}