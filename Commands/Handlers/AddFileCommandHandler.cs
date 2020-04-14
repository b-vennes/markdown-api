namespace MarkdownManager.Commands.Handlers
{
    using System.Threading;
    using System.Threading.Tasks;
    using Paramore.Brighter;

    public class AddFileCommandHandler : RequestHandlerAsync<AddFileCommand>
    {
        public override async Task<AddFileCommand> HandleAsync(AddFileCommand command, CancellationToken cancellationToken = default)
        {
            return await base.HandleAsync(command);
        }
    }
}