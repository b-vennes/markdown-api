namespace MarkdownManager.Commands
{
    using System;
    using MarkdownManager.Models;
    using Paramore.Brighter;

    public class AddFileCommand : IRequest
    {
        public AddFileCommand(AddFileRequest addFileRequest)
        {
            Content = addFileRequest.Content;
            Id = Guid.NewGuid();
        }

        public string Content { get; set; }

        public Guid Id { get; set; }
    }
}