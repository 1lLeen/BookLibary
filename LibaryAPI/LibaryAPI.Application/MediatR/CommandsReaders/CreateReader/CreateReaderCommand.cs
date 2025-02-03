using LibaryAPI.Domain.DTOs.Readers;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsReaders.CreateReader;

public class CreateReaderCommand:IRequest<GetReaderDto>
{
    public CreateReaderDto CreateReaderDto{ get; set; }
}
