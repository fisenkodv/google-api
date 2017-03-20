using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GoogleApi
{
  internal sealed class ApiClient
  {
    private readonly JsonSerializer _jsonSerializer;

    public ApiClient()
    {
      _jsonSerializer = JsonSerializer.Create();
    }

    public async Task<T> GetResponse<T>(string queryUrl)
    {
      using (var client = new HttpClient())
      {
        var json = await client.GetStringAsync(queryUrl);
        using (JsonTextReader jsonTextReader = new JsonTextReader(new StringReader(json)))
        {
          var response = _jsonSerializer.Deserialize<T>(jsonTextReader);
          return response;
        }
      }
    }
  }
}