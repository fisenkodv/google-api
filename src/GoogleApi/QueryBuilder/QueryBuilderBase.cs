using System.Collections.Generic;
using System.Linq;
using GoogleApi.Places.Search.ParameterBuilder.QueryBuilder;

namespace GoogleApi.QueryBuilder
{
  internal abstract class QueryBuilderBase : IHttpQueryBuilder
  {
    private readonly List<QueryParameter> _parameters;

    private readonly string _baseUrl;

    protected QueryBuilderBase(string baseUrl, string apiKey)
    {
      _baseUrl = baseUrl;
      _parameters = new List<QueryParameter>();

      AddParameter(ApiParameters.ApiKey, apiKey);
    }

    public string Build()
    {
      var parameters = from parameter in _parameters
        let queryParameter = parameter.ParameterWithoutValue
          ? parameter.Name
          : $"{parameter.Name}={parameter.Value}"
        select queryParameter;

      return $"{_baseUrl}{string.Join("&", parameters)}";
    }

    protected void AddParameter(string name, string value)
    {
      _parameters.Add(new QueryParameter(name, value, false));
    }

    protected void AddParameter(string name)
    {
      _parameters.Add(new QueryParameter(name, null, true));
    }

    private string GetParameter(string name)
    {
      return _parameters.FirstOrDefault(x => x.Name == name).Value;
    }

    public bool IsParameterPresent(string name)
    {
      return !string.IsNullOrEmpty(GetParameter(name));
    }

    private class QueryParameter
    {
      public QueryParameter(string name, string value, bool parameterWithoutValue)
      {
        Name = name;
        Value = value;
        ParameterWithoutValue = parameterWithoutValue;
      }

      public string Name { get; private set; }
      public string Value { get; private set; }
      public bool ParameterWithoutValue { get; private set; }
    }
  }
}