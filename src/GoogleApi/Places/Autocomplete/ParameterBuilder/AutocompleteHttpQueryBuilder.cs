using System.Linq;
using GoogleApi.Attributes;
using GoogleApi.Places.Autocomplete.Types;
using GoogleApi.Places.Search.ParameterBuilder.QueryBuilder;
using GoogleApi.Places.Types;

namespace GoogleApi.Places.Autocomplete.ParameterBuilder
{
  internal class AutocompleteHttpQueryBuilder : SearchQueryBuilderBase, IAutocompleteHttpQueryBuilder
  {
    private const string BaseUrl = "https://maps.googleapis.com/maps/api/place/autocomplete/json?";

    public AutocompleteHttpQueryBuilder(string apiKey)
      : base(BaseUrl, apiKey)
    {
    }

    public IAutocompleteHttpQueryBuilder Input(string input)
    {
      AddParameter(ApiParameters.Input, input);
      return this;
    }

    public IAutocompleteHttpQueryBuilder Offset(int offset)
    {
      AddParameter(ApiParameters.Offset, offset.ToString());
      return this;
    }

    public IAutocompleteHttpQueryBuilder Location(double latitude, double longitude)
    {
      AddParameter(ApiParameters.Location, $"{latitude},{longitude}");
      return this;
    }

    public IAutocompleteHttpQueryBuilder Radius(int radius)
    {
      AddParameter(ApiParameters.Radius, radius.ToString());
      return this;
    }

    public IAutocompleteHttpQueryBuilder Language(Languages language)
    {
      CodeAttribute codeAttribute = ArrtibutesHelper.GetEnumCodeAttribute(language);
      AddParameter(ApiParameters.Language, codeAttribute?.Code);
      return this;
    }

    public IAutocompleteHttpQueryBuilder Types(PlaceTypes placeTypes)
    {
      CodeAttribute codeAttribute = ArrtibutesHelper.GetEnumCodeAttribute(placeTypes);
      AddParameter(ApiParameters.Types, codeAttribute?.Code);
      return this;
    }

    public IAutocompleteHttpQueryBuilder Components(params string[] countryCodes)
    {
      string components = string.Join("|", countryCodes.Select(code => $"country:{code}"));
      AddParameter(ApiParameters.Components, components);
      return this;
    }

    public IAutocompleteHttpQueryBuilder StrictBounds()
    {
      AddParameter(ApiParameters.Strictbounds);
      return this;
    }
  }
}