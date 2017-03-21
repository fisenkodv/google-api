# Google API

## [Google Places API](https://developers.google.com/places/web-service/)

## Place Search (https://developers.google.com/places/web-service/search)
### Nearby Search

```csharp
GoogleClientSecrets clientSecrets = new GoogleClientSecrets(new[] {(PlacesBuilder.ApiName, "API_KEY") });
INearbyHttpQueryBuilder searchQueryBuilder =
  PlacesBuilder.Create(_clientSecrets)
    .NearbySearch()
    .Radius(1000)
    .Keyword("bank")
    .Location(42.201154, -85.580002)
    .Language(Languages.English);

NearbyResult results = await PlacesClient.NearbySearch(searchQueryBuilder);
```

### Text Search
```csharp
GoogleClientSecrets clientSecrets = new GoogleClientSecrets(new[] {(PlacesBuilder.ApiName, "API_KEY") });
ITextHttpQueryBuilder textQueryBuilder =
  PlacesBuilder.Create(_clientSecrets)
    .TextSearch()
    .Radius(100)
    .Query("bank")
    .Location(42.201154, -85.580002);

TextResult results = await PlacesClient.TextSearch(textQueryBuilder);
```

### Radar Search
```csharp
GoogleClientSecrets clientSecrets = new GoogleClientSecrets(new[] {(PlacesBuilder.ApiName, "API_KEY") });
IRadarHttpQueryBuilder radarQueryBuilder =
  PlacesBuilder.Create(_clientSecrets)
    .RadarSearch()
    .Radius(1000)
    .Keyword("bank")
    .Location(42.201154, -85.580002);

RadarResult results = await PlacesClient.RadarSearch(radarQueryBuilder);
```

## Place Autocomplete (https://developers.google.com/places/web-service/autocomplete)

### Autocomplete
```csharp
GoogleClientSecrets clientSecrets = new GoogleClientSecrets(new[] {(PlacesBuilder.ApiName, "API_KEY") });
IAutocompleteHttpQueryBuilder autocompleteQueryBuilder =
  PlacesBuilder.Create(_clientSecrets)
    .Autocomplete()
    .Radius(1000)
    .Input("kalamazoo")
    .Types(PlaceTypes.Cities)
    .Location(42.201154, -85.580002);

AutocompleteResult results = await PlacesClient.Autocomplete(autocompleteQueryBuilder);
```