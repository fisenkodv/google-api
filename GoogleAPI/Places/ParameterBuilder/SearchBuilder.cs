using System;
using GoogleAPI.Places.ParameterBuilder.Fluent;
using GoogleAPI.Places.ParameterBuilder.QueryBuilder;

namespace GoogleAPI.Places.ParameterBuilder
{
  public class SearchBuilder : ISearchBuilder
  {
    private readonly string _apiKey;

    private SearchBuilder( string apiKey )
    {
      _apiKey = apiKey;
    }

    public static SearchBuilder Create( string apiKey )
    {
      return new SearchBuilder( apiKey );
    }

    public INearbySearchSearchQueryBuilder NearbySearch()
    {
      return new NearbySearchSearchQueryBuilder( _apiKey );
    }

    public ITextSearchSearchQueryBuilder TextSearch()
    {
      return new TextSearchSearchQueryBuilder( _apiKey );
    }
  }
}