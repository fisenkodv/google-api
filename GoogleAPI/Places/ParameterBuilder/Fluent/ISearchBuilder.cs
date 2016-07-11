namespace GoogleAPI.Places.ParameterBuilder.Fluent
{
  public interface ISearchBuilder
  {
    INearbySearchSearchQueryBuilder NearbySearch();
    ITextSearchSearchQueryBuilder TextSearch();
  }
}