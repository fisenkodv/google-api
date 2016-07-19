using GoogleAPI.Places.ParameterBuilder.Interfaces;
using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.QueryBuilder
{
  internal class TextSearchSearchQueryBuilder : SearchQueryBuilderBase, ITextSearchSearchQueryBuilder
  {
    private const string BaseUrl = "https://maps.googleapis.com/maps/api/place/textsearch/json?";

    public TextSearchSearchQueryBuilder( string apiKey )
      : base( BaseUrl, apiKey )
    {
    }

    public ITextSearchSearchQueryBuilder Query( string query )
    {
      SetQuery( query );
      return this;
    }

    public ITextSearchSearchQueryBuilder Location( double latitude, double longitude )
    {
      SetLocation( latitude, longitude );
      return this;
    }

    public ITextSearchSearchQueryBuilder Radius( int radius )
    {
      SetRadius( radius );
      return this;
    }

    public ITextSearchSearchQueryBuilder Language( Languages language )
    {
      SetLanguage( language );
      return this;
    }

    public ITextSearchSearchQueryBuilder Price( int? minprice, int? maxprice )
    {
      SetPrice( minprice, maxprice );
      return this;
    }

    public ITextSearchSearchQueryBuilder PageToken( string pageToken )
    {
      SetPageToken( pageToken );
      return this;
    }

    public ITextSearchSearchQueryBuilder Type( SearchTypes type )
    {
      SetType( type );
      return this;
    }
  }
}