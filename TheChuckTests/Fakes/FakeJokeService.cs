using TheChuck.Models;
using TheChuck.Services;

namespace TheChuckTests.Fakes
{
    internal class FakeJokeService : IJokeService
    {
        private readonly Joke joke;

        public FakeJokeService(Joke joke)
        {
            this.joke = joke;
        }

        public Task<Joke?> GetJokeFromCategory(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<Joke?> GetRandomJoke()
        {
            return await Task.FromResult(joke);
        }
    }
}
