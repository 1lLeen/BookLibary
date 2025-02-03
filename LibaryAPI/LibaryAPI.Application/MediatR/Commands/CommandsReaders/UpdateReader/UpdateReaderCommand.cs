using LibaryAPI.Domain.DTOs.Readers;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsReaders.UpdateReader;

public class UpdateReaderCommand:IRequest<GetReaderDto>
{
    public UpdateReaderDto UpdateReaderDto { get; set; }
}
