#Google API

## Search API (https://developers.google.com/places/web-service/search)
### Nearby Search

```csharp
string apiKey = "API_KEY";
INearbySearchSearchQueryBuilder searchQueryBuilder =
  SearchBuilder.Create( apiKey )
    .TextSearch()
    .Radius( 100 )
    .Query( "bank" )
    .Location( 42.201154, -85.580002 );
PlacesApiResponse response = new SearchApiClient( searchQueryBuilder ).Search()
```

### Text Search
```csharp
string apiKey = "API_KEY";
ITextSearchSearchQueryBuilder textQueryBuilder =
  SearchBuilder.Create( apiKey )
    .TextSearch()
    .Radius( 100 )
    .Query( "bank" )
    .Location( 42.201154, -85.580002 );
PlacesApiResponse response = new SearchApiClient( textQueryBuilder ).Search()
```

### Radar Search
```csharp
string apiKey = "API_KEY";
IRadarSearchSearchQueryBuilder radarQueryBuilder =
  SearchBuilder.Create( apiKey )
    .RadarSearch()
    .Radius( 1000 )
    .Keyword( "bank" )
    .Location( 42.201154, -85.580002 );
PlacesApiResponse response = new SearchApiClient( radarQueryBuilder ).Search()
```