using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.DeleteReaderNewsletter;

public class DeleteReaderNewsletterCommand : IRequest<GetReaderNewsletterDto>
{
    public int Id { get; set; }
    public DeleteReaderNewsletterCommand(int id) =>
        Id = id;
}

