using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsReadersNewsletter.UpdateReaderNewsletter;

public class UpdateReaderNewsletterCommand : IRequest<GetReaderNewsletterDto>
{
    public UpdateReaderNewsletterDto UpdateReaderNewsletterDto { get; set; }
}
