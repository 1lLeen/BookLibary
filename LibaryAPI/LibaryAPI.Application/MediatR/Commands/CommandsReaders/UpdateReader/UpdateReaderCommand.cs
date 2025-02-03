using LibaryAPI.Domain.DTOs.Readers;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReaders.UpdateReader;

public class UpdateReaderCommand : IRequest<GetReaderDto>
{
    public UpdateReaderDto UpdateReaderDto { get; set; }
    public int Id { get; set; }
    public UpdateReaderCommand(UpdateReaderDto updateReaderDto, int id) 
    {
        UpdateReaderDto = updateReaderDto;
        Id = id;
    }
}
