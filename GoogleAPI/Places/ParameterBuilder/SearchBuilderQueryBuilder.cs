using System;
using GoogleAPI.Places.ParameterBuilder.FluentInterfaces;
using GoogleAPI.Places.ParameterBuilder.SearchBuilders;

namespace GoogleAPI.Places.ParameterBuilder
{
  public class SearchBuilder : ISearchBuilderType
  {
    private readonly string _apiKey;

    public SearchBuilder( string apiKey )
    {
      _apiKey = apiKey;
    }

    public INearbySearchSearchBuilder NearbySearch()
    {
      return new NearbySearchSearchBuilder( _apiKey );
    }

    public ITextSearchSearchBuilder TextSearch()
    {
      return new TextSearchSearchBuilder( _apiKey );
    }
  }
}