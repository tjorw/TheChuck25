using TheChuck.Models;
using TheChuck.Services;

namespace TheChuckTests.Fakes
{
    internal class FakeJokeService : IJokeService
    {
        public Task<Joke?> GetJokeFromCategory(string category)
        {
            throw new NotImplementedException();
        }

        public async Task<Joke?> GetRandomJoke()
        {
            var result = new Joke()
            {
                Value = "Works"
            };

            return await Task.FromResult(result);
        }
    }
}
