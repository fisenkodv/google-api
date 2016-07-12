using GoogleAPI.Places.Entities;
using GoogleAPI.Places.ParameterBuilder.Interfaces;

namespace GoogleAPI.Places
{
  public class SearchApiClient : ApiClient<PlacesApiResponse>
  {
    private readonly ISearchQueryBuilder _searchQueryBuilder;

    public SearchApiClient( ISearchQueryBuilder searchQueryBuilder )
    {
      _searchQueryBuilder = searchQueryBuilder;
    }

    public PlacesApiResponse Search()
    {
      return GetResponse();
    }

    protected override string GetQueryUrl()
    {
      return _searchQueryBuilder.Build();
    }
  }
}