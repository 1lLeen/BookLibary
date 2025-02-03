using LibaryAPI.Domain.DTOs.Readers;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReaders.UpdateReader;

public class UpdateReaderCommand : IRequest<GetReaderDto>
{
    public UpdateReaderDto UpdateReaderDto { get; set; }
}
