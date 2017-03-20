using GoogleApi.Attributes;
using GoogleApi.Places.Search.Types;
using GoogleApi.Places.Types;
using GoogleApi.QueryBuilder;

namespace GoogleApi.Places.Search.ParameterBuilder.QueryBuilder
{
  internal class SearchQueryBuilderBase : QueryBuilderBase
  {
    public SearchQueryBuilderBase(string baseUrl, string apiKey) :
      base(baseUrl, apiKey)
    {
    }

    public void SetQuery(string query)
    {
      AddParameter(ApiParameters.Query, query);
    }

    public void SetRadius(int radius)
    {
      AddParameter(ApiParameters.Radius, radius.ToString());
    }

    public void SetLocation(double latitude, double longitude)
    {
      AddParameter(ApiParameters.Location, $"{latitude},{longitude}");
    }

    public void SetRankingBy(RankBy rankBy)
    {
      AddParameter(ApiParameters.RankBy, rankBy.ToString().ToLowerInvariant());
    }

    public void SetKeyword(string keyword)
    {
      AddParameter(ApiParameters.Keyword, keyword);
    }

    public void SetLanguage(Languages language)
    {
      CodeAttribute codeAttribute = ArrtibutesHelper.GetEnumCodeAttribute(language);
      AddParameter(ApiParameters.Language, codeAttribute?.Code);
    }

    public void SetPrice(int? minprice, int? maxprice)
    {
      if (minprice.HasValue)
        AddParameter(ApiParameters.MinPrice, minprice.Value.ToString());

      if (maxprice.HasValue)
        AddParameter(ApiParameters.MaxnPrice, maxprice.Value.ToString());
    }

    public void SetNames(params string[] names)
    {
      AddParameter(ApiParameters.Name, string.Join("|", names));
    }

    public void SetPageToken(string pageToken)
    {
      AddParameter(ApiParameters.PageToken, pageToken);
    }

    public void SetType(SearchTypes type)
    {
      AddParameter(ApiParameters.Type, type.ToString().ToLowerInvariant());
    }
  }
}