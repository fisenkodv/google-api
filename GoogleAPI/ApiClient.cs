using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace GoogleAPI.Places
{
  public abstract class ApiClient<T>
  {
    protected ApiClient( )
    {
    }

    protected abstract string GetQueryUrl();

    protected T GetResponse()
    {
      using ( var client = new WebClient())
      {
        var json = client.DownloadString(GetQueryUrl());
        var response = JsonSerializer.Create().Deserialize<T>(new JsonTextReader(new StringReader(json)));
        return response;
      }
    }
  }
}