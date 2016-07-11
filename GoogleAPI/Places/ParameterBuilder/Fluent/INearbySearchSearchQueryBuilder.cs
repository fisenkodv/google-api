using GoogleAPI.Places.Types;

namespace GoogleAPI.Places.ParameterBuilder.Fluent
{
  public interface INearbySearchSearchQueryBuilder: ISearchQueryBuilder
  {
    INearbySearchSearchQueryBuilder Radius( int radius );
    INearbySearchSearchQueryBuilder Location(double latitude, double longitude);
    INearbySearchSearchQueryBuilder RankingBy(RankBy rankBy);
    INearbySearchSearchQueryBuilder Keyword(string keyword);
    INearbySearchSearchQueryBuilder Language(string language);
    INearbySearchSearchQueryBuilder Price(int? minprice, int? maxprice);
    INearbySearchSearchQueryBuilder Names(params string[] names);
  }
}