using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.Fluent
{
  public interface ITextSearchSearchQueryBuilder : ISearchQueryBuilder
  {
    ITextSearchSearchQueryBuilder Query( string query );
    ITextSearchSearchQueryBuilder Location( double latitude, double longitude );
    ITextSearchSearchQueryBuilder Radius( int radius );
    ITextSearchSearchQueryBuilder Language( string language );
    ITextSearchSearchQueryBuilder Price( int? minprice, int? maxprice );
    ITextSearchSearchQueryBuilder PageToken( string pageToken );
    ITextSearchSearchQueryBuilder Type( SearchTypes type );
  }
}