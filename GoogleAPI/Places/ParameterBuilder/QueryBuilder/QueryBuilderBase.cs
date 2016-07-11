using System.Collections.Generic;
using System.Linq;
using GoogleAPI.Places.ParameterBuilder.Fluent;

namespace GoogleAPI.Places.ParameterBuilder.QueryBuilder
{
  internal abstract class QueryBuilderBase: ISearchQueryBuilder
  {
    private readonly List<KeyValuePair<string, string>> _parameters;

    private readonly string _baseUrl;

    public QueryBuilderBase( string baseUrl )
    {
      _baseUrl = baseUrl;
      _parameters = new List<KeyValuePair<string, string>>();
    }

    public string Build()
    {
      return $"{_baseUrl}{string.Join( "&", _parameters.Select( p => $"{p.Key}={p.Value}" ) )}";
    }

    public void AddParameter( string name, string value )
    {
      _parameters.Add( new KeyValuePair<string, string>( name, value ) );
    }

    public string GetParameter( string name )
    {
      return _parameters.FirstOrDefault( x => x.Key == name ).Value;
    }

    public bool IsParameterPresent( string name )
    {
      return !string.IsNullOrEmpty( GetParameter( name ) );
    }
  }
}