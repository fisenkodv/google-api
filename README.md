#Google API

## Search API (https://developers.google.com/places/web-service/search)
### Nearby Search

```csharp
string apiKey = "API_KEY";
INearbySearchSearchQueryBuilder searchQueryBuilder =
  SearchBuilder.Create( apiKey )
  .NearbySearch()
  .Radius( 100 )
  .Keyword( "Village" )
  .Location( 42.226420, -85.600134 );
PlacesApiResponse response = new SearchApiClient( searchQueryBuilder ).Search()
```

### Text Search
```csharp
string apiKey = "API_KEY";
ITextSearchSearchQueryBuilder textqQueryBuilder =
  SearchBuilder.Create( apiKey )
  .TextSearch()
  .Radius( 100 )
  .Query( "Village" )
  .Location( 42.226420, -85.600134 );
PlacesApiResponse response = new SearchApiClient( searchQueryBuilder ).Search()
```

### Radar Search
***not implemented yet***