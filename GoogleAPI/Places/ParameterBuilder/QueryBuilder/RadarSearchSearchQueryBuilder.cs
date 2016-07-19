using GoogleAPI.Places.ParameterBuilder.Interfaces;
using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.QueryBuilder
{
  internal class RadarSearchSearchQueryBuilder : SearchQueryBuilderBase, IRadarSearchSearchQueryBuilder
  {
    private const string BaseUrl = "https://maps.googleapis.com/maps/api/place/radarsearch/json?";

    public RadarSearchSearchQueryBuilder( string apiKey )
      : base( BaseUrl, apiKey )
    {
    }

    public IRadarSearchSearchQueryBuilder Location( double latitude, double longitude )
    {
      SetLocation( latitude, longitude );
      return this;
    }

    public IRadarSearchSearchQueryBuilder Radius( int radius )
    {
      SetRadius( radius );
      return this;
    }

    public IRadarSearchSearchQueryBuilder Keyword( string keyword )
    {
      SetKeyword( keyword );
      return this;
    }

    public IRadarSearchSearchQueryBuilder Language( Languages language )
    {
      SetLanguage( language );
      return this;
    }

    public IRadarSearchSearchQueryBuilder Price( int? minprice, int? maxprice )
    {
      SetPrice( minprice, maxprice );
      return this;
    }

    public IRadarSearchSearchQueryBuilder Names( params string[] names )
    {
      SetNames( names );
      return this;
    }

    public IRadarSearchSearchQueryBuilder Type( SearchTypes type )
    {
      SetType( type );
      return this;
    }
  }
}