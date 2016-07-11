using GoogleAPI.Places;
using System;
using System.Globalization;
using System.Linq;
using GoogleAPI.Places.Entities;
using GoogleAPI.Places.ParameterBuilder;
using GoogleAPI.Places.ParameterBuilder.Fluent;

namespace GoogleAPI.ConsoleApp
{
  class Program
  {
    static void Main( string[] args )
    {
      string apiKey = "API_KEY";

      INearbySearchSearchQueryBuilder searchQueryBuilder =
        SearchBuilder.Create( apiKey )
        .NearbySearch()
        .Radius( 100 )
        .Keyword( "Village" )
        .Location( 42.226420, -85.600134 );

      ShowResults( new SearchApiClient( searchQueryBuilder ).Search() );

      ITextSearchSearchQueryBuilder textqQueryBuilder =
        SearchBuilder.Create( apiKey )
        .TextSearch()
        .Radius( 100 )
        .Query( "Village" )
        .Location( 42.226420, -85.600134 );

      ShowResults( new SearchApiClient( textqQueryBuilder ).Search() );
    }

    private static void ShowResults( PlacesApiResponse response )
    {
      TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
      Console.WriteLine( $"Status: {response.Status}" );
      foreach ( var result in response.Results )
      {
        Console.WriteLine( $"\t[{result.PlaceId}] Name: {result.Name} ({string.Join( ",", result.Types.Select( t => textInfo.ToTitleCase( t.Replace( "_", " " ) ) ) )})" );
      }
    }
  }
}
