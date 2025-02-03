using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsReadersNewsletter.CreateReaderNewsletter;

public class CreateReaderNewsletterCommand : IRequest<GetReaderNewsletterDto>
{
    public CreateReaderNewsletterDto CreateReaderNewsletterDto { get; set; }
}

