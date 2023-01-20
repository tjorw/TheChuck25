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
    string Url = "https://api.chucknorris.io/jokes/random?category=" + category;

    try
    {
      var joke = await _webClient.Get<Joke>(Url) ?? new Joke();
      return joke;
    }
    catch (Exception ex)
    {
      //Normally, I would handle this exception instead of swallowing it, passing it up to the line, or logging it. However, in this excercise, I am unsure what I should do with it.
      _logger.LogError(ex, "Det gick inte att hämta joke via kategori", category);
      return null;
    }
  }

  public async Task<Joke?> GetRandomJoke()
  {
    string Url = "https://api.chucknorris.io/jokes/random";

    try
    {
      var joke = await _webClient.Get<Joke>(Url) ?? new Joke();
      return joke;
    }
    catch (Exception ex)
    {
      //Normally, I would handle this exception instead of swallowing it, passing it up to the line, or logging it. However, in this excercise, I am unsure what I should do with it.
      _logger.LogError(ex, "Det gick inte att hämta ett joke ");
      return null;
    }
  }

}
