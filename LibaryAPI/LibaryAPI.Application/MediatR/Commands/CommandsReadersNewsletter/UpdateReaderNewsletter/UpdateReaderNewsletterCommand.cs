using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.UpdateReaderNewsletter;

public class UpdateReaderNewsletterCommand : IRequest<GetReaderNewsletterDto>
{
    public UpdateReaderNewsletterDto UpdateReaderNewsletterDto { get; set; }
    public int Id { get; set; }

    public UpdateReaderNewsletterCommand(int id, UpdateReaderNewsletterDto updateReaderNewsletterDto) 
    {
        UpdateReaderNewsletterDto = updateReaderNewsletterDto;
        Id = id;
    }
}
