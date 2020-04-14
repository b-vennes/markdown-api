namespace MarkdownManager.Commands
{
    using System;
    using Paramore.Brighter;

    public class AddFileCommand : IRequest
    {
        public AddFileCommand(string content)
        {
            Content = content;
            Id = Guid.NewGuid();
        }

        public string Content { get; set; }

        public Guid Id { get; set; }
    }
}