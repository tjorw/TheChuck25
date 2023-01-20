using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheChuck.Models;
using TheChuck.Services;

namespace TheChuck.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IJokeService _jokeService;

        [BindProperty(SupportsGet = true)]
        public string? Who { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IJokeService jokeService)
        {
            _logger = logger;
            _jokeService = jokeService;
        }

        public string DisplayText { get; private set; } = "";

        public async Task OnGet()
        {
            var joke =  await _jokeService.GetRandomJoke();
            DisplayText = joke?.Value ?? "";
        }
    }
}