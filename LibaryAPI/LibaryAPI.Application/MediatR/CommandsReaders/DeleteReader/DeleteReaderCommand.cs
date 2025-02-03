using LibaryAPI.Domain.DTOs.Readers;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsReaders.DeleteReader;

public class DeleteReaderCommand:IRequest<GetReaderDto>
{
    public int Id { get; set; }
}

