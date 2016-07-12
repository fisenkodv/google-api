using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.Interfaces
{
  /// <summary>
  /// The Google Places API Radar Search Service allows you to search for up to 200 places at once, 
  /// but with less detail than is typically returned from a Text Search or Nearby Search request. 
  /// With Radar Search, you can create applications that help users identify specific areas of interest within a geographic area.
  /// </summary>
  public interface IRadarSearchSearchQueryBuilder : ISearchQueryBuilder
  {
    IRadarSearchSearchQueryBuilder Location( double latitude, double longitude );
    IRadarSearchSearchQueryBuilder Radius( int radius );
    IRadarSearchSearchQueryBuilder Keyword( string keyword );
    IRadarSearchSearchQueryBuilder Language( string language );
    IRadarSearchSearchQueryBuilder Price( int? minprice, int? maxprice );
    IRadarSearchSearchQueryBuilder Names( params string[] names );
    IRadarSearchSearchQueryBuilder Type( SearchTypes type );
  }
}