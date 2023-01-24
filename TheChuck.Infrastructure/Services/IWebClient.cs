namespace TheChuck.Infrastructure.Services;

public interface IWebClient
{
    Task<T?> Get<T>(string url) where T : class;
}
