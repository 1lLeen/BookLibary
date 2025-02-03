using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.DeleteReaderNewsletter;

public class DeleteReaderNewsletterCommand : IRequest<GetReaderNewsletterDto>
{
    public int Id { get; set; }
}

