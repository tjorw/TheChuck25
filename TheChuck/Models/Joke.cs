namespace TheChuck.Models;
public class Joke
{
  public string[] Categories { get; set; } = new string[] {};
  public string Created_at { get; set; } = string.Empty;
  public string Icon_url { get; set; } = string.Empty;
  public string Id { get; set; } = string.Empty;
  public string Updated_at { get; set; } = string.Empty;
  public string Url { get; set; } = string.Empty;
  public string Value { get; set; } = string.Empty;
}
