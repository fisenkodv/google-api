using GoogleApi.Places.Search.ParameterBuilder.Interfaces;

namespace GoogleApi.Places
{
  public interface IPlacesBuilder
  {
    INearbyHttpQueryBuilder NearbySearch();
    ITextHttpQueryBuilder TextSearch();
    IRadarHttpQueryBuilder RadarSearch();
  }
}