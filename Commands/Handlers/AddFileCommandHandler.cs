namespace MarkdownManager.Commands.Handlerse
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using Paramore.Brighter;

    public class AddFileCommandHandler : RequestHandlerAsync<AddFileCommand>
    {
        private readonly ILogger<AddFileCommandHandler> _logger;
        public AddFileCommandHandler(ILogger<AddFileCommandHandler> logger)
        {
            _logger = logger;
        }

        public override async Task<AddFileCommand> HandleAsync(AddFileCommand command, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation(command.Content);

            return await base.HandleAsync(command);
        }
    }
}