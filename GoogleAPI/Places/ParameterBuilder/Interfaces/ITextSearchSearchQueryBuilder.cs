using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.Interfaces
{
  /// <summary>
  /// The Google Places API Text Search Service is a web service that returns information 
  /// about a set of places based on a string — for example "pizza in New York" or "shoe stores near Ottawa". 
  /// The service responds with a list of places matching the text string and any location bias that has been set. 
  /// The search response will include a list of places, you can send a Place Details request for more information
  /// about any of the places in the response.
  /// </summary>
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