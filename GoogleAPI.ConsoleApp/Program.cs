using GoogleAPI.Places;
using System;
using System.Globalization;
using System.Linq;
using GoogleAPI.Places.Entities;
using GoogleAPI.Places.ParameterBuilder;
using GoogleAPI.Places.ParameterBuilder.Interfaces;

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
        .Radius( 1000 )
        .Keyword( "bank" )
        .Location( 42.201154, -85.580002 );

      ShowResults( new SearchApiClient( searchQueryBuilder ).Search(), "Nearby Search" );

      ITextSearchSearchQueryBuilder textQueryBuilder =
        SearchBuilder.Create( apiKey )
        .TextSearch()
        .Radius( 100 )
        .Query( "bank" )
        .Location( 42.201154, -85.580002 );

      ShowResults( new SearchApiClient( textQueryBuilder ).Search(), "Text Search" );

      IRadarSearchSearchQueryBuilder radarQueryBuilder =
        SearchBuilder.Create( apiKey )
          .RadarSearch()
          .Radius( 1000 )
          .Keyword( "bank" )
          .Location( 42.201154, -85.580002 );

      ShowResults( new SearchApiClient( radarQueryBuilder ).Search(), "Radar Search" );
    }

    private static void ShowResults( PlacesApiResponse response, string resultInfo )
    {
      Console.WriteLine( resultInfo );
      Console.WriteLine( new string( '-', 40 ) );
      TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
      Console.WriteLine( $"Status: {response.Status}" );
      foreach ( var result in response.Results )
      {
        Console.Write( $"\t[{result.PlaceId}]" );
        if ( !string.IsNullOrEmpty( result.Name ) )
          Console.Write( $" Name: {result.Name}" );
        if ( result.Types != null )
          Console.Write( $" ({string.Join( ", ", result.Types.Select( t => textInfo.ToTitleCase( t.Replace( "_", " " ) ) ) )})" );

        Console.Write( "\n" );
      }

      Console.WriteLine( new string( '=', 40 ) );
    }
  }
}
