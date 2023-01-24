using TheChuck.Core;
using TheChuck.Infrastructure.Services;

namespace TheChuck.Infrastructure;

public class JokeService : IJokeService
{
    private readonly IWebClient _webClient;

    public JokeService(IWebClient webClient)
    {
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
            throw new Exception(errorMessage, ex);
        }
    }

}
