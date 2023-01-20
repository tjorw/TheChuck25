
using TheChuck.Models;

namespace TheChuck.Services;

public interface IJokeService
{
  Task<Joke?> GetJokeFromCategory(string category);
  Task<Joke?> GetRandomJoke();
}
