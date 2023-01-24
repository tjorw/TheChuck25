using TheChuck.Core;

namespace TheChuckTests.Fakes
{
    internal class JokeServiceBrokenFake : IJokeService
    {

        public Task<Joke?> GetJokeFromCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<Joke?> GetRandomJoke()
        {
            throw new NotImplementedException();
        }
    }
}


