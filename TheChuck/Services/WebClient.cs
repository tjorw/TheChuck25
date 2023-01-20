
using Newtonsoft.Json;

namespace TheChuck.Services;
public class WebClient : IWebClient
{
  public virtual async Task<T?> Get<T>(string url) where T : class
  {

    using (var client = new HttpClient())
    {
      var stringResult = await client.GetStringAsync(url);
      return JsonConvert.DeserializeObject<T>(stringResult);
    }
  }
}
