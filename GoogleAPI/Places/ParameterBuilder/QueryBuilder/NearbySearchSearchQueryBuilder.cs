using GoogleAPI.Places.ParameterBuilder.Fluent;
using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.QueryBuilder
{
  internal class NearbySearchSearchQueryBuilder : SearchQueryBuilderBase, INearbySearchSearchQueryBuilder
  {
    private const string BaseUrl = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";

    public NearbySearchSearchQueryBuilder( string apiKey )
      : base( BaseUrl, apiKey )
    {
    }

    public INearbySearchSearchQueryBuilder Radius( int radius )
    {
      SetRadius( radius );
      return this;
    }

    public INearbySearchSearchQueryBuilder Location( double latitude, double longitude )
    {
      SetLocation( latitude, longitude );
      return this;
    }

    public INearbySearchSearchQueryBuilder RankingBy( RankBy rankBy )
    {
      SetRankingBy( rankBy );
      return this;
    }

    public INearbySearchSearchQueryBuilder Keyword( string keyword )
    {
      SetKeyword( keyword );
      return this;
    }

    public INearbySearchSearchQueryBuilder Language( string language )
    {
      SetLanguage( language );
      return this;
    }

    public INearbySearchSearchQueryBuilder Price( int? minprice, int? maxprice )
    {
      SetPrice( minprice, maxprice );
      return this;
    }

    public INearbySearchSearchQueryBuilder Names( params string[] names )
    {
      SetNames( names );
      return this;
    }
  }
}