namespace MarkdownManager.Controllers
{
    using System;
    using System.Threading.Tasks;
    using MarkdownManager.Commands;
    using MarkdownManager.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Paramore.Brighter;

    [ApiController]
    [Route("[controller]")]
    public class MarkdownController : ControllerBase
    {
        private readonly ILogger<MarkdownController> _logger;
        private readonly IAmACommandProcessor _commandProcessor;

        public MarkdownController(ILogger<MarkdownController> logger, IAmACommandProcessor commandProcessor)
        {
            _logger = logger;
            _commandProcessor = commandProcessor;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddFileRequest content)
        {
            var command = new AddFileCommand(content);

            try
            {
                await _commandProcessor.SendAsync(command);
            }
            catch (Exception exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Failed to add the content: {exception.Message}.");
            }

            return Ok();
        }
    }
}