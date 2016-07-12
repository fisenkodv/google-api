namespace GoogleAPI.Places.ParameterBuilder.Interfaces
{
  public interface ISearchBuilder
  {
    INearbySearchSearchQueryBuilder NearbySearch();
    ITextSearchSearchQueryBuilder TextSearch();
    IRadarSearchSearchQueryBuilder RadarSearch();
  }
}