using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.Interfaces
{
  /// <summary>
  /// A Nearby Search lets you search for places within a specified area. 
  /// You can refine your search request by supplying keywords or specifying the type of place you are searching for.
  /// </summary>
  public interface INearbySearchSearchQueryBuilder : ISearchQueryBuilder
  {
    INearbySearchSearchQueryBuilder Radius( int radius );
    INearbySearchSearchQueryBuilder Location( double latitude, double longitude );
    INearbySearchSearchQueryBuilder RankingBy( RankBy rankBy );
    INearbySearchSearchQueryBuilder Keyword( string keyword );
    INearbySearchSearchQueryBuilder Language( Languages language );
    INearbySearchSearchQueryBuilder Price( int? minprice, int? maxprice );
    INearbySearchSearchQueryBuilder Names( params string[] names );
  }
}