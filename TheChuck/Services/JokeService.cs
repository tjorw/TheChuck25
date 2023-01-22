using System.Net;
using TheChuck.Models;

namespace TheChuck.Services;

public class JokeService : IJokeService
{
  private readonly ILogger<JokeService> _logger;
  private readonly IWebClient _webClient;

  public JokeService(ILogger<JokeService> logger, IWebClient webClient)
  {
    _logger = logger;
    _webClient = webClient;
  }

  public async Task<Joke?> GetJokeFromCategory(string category)
  {
    string url = "https://api.chucknorris.io/jokes/random?category=" + category;

    try
    {
      var joke = await _webClient.Get<Joke>(url) ?? new Joke();
      return joke;
    }
    catch (Exception ex)
    {
      var errorMessage = "Det gick inte att hämta joke via kategori";
      _logger.LogError(ex, errorMessage, url);
      throw new Exception(errorMessage, ex);
    }
  }

  public async Task<Joke?> GetRandomJoke()
  {
    string url = "https://api.chucknorris.io/jokes/random";

    try
    {
      var joke = await _webClient.Get<Joke>(url) ?? new Joke();
      return joke;
    }
    catch (Exception ex)
    {
      var errorMessage = "Det gick inte att hämta joke";
      _logger.LogError(ex, errorMessage, url);
      throw new Exception(errorMessage, ex);
    }
  }

}
