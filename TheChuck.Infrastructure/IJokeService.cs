namespace TheChuck.Core;

public interface IJokeService
{
    Task<Joke?> GetJokeFromCategory(string category);
    Task<Joke?> GetRandomJoke();
}
