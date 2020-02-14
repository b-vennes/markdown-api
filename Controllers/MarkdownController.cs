namespace markdown_api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    public class MarkdownController : ControllerBase
    {
        private readonly ILogger<MarkdownController> _logger;

        public MarkdownController(ILogger<MarkdownController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMarkdown(string id)
        {

        }

        [HttpPost]
        public async Task<IActionResult> PublishMarkdown(string fileUrl)
        {

        }
    }
}