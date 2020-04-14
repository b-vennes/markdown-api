namespace MarkdownManager.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Paramore.Brighter;
    using Paramore.Darker;

    public class MarkdownController : ControllerBase
    {
        private readonly ILogger<MarkdownController> _logger;
        private readonly IAmACommandProcessor _commandProcessor;
        private readonly IQueryProcessor _queryProcessor;

        public MarkdownController(ILogger<MarkdownController> logger, IAmACommandProcessor commandProcessor, IQueryProcessor queryProcessor)
        {
            _logger = logger;
            _commandProcessor = commandProcessor;
            _queryProcessor = queryProcessor;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Query(string id)
        {

        }

        [HttpPost]
        public async Task<IActionResult> Add(IFormFile file)
        {
            var command = new AddFileCommand(file);
        }
    }
}