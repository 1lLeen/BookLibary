using LibaryAPI.Domain.DTOs.Readers;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibaryAPI.Application.MediatR.Queries.GetReader;

public class GetReaderQuery : IRequest<GetReaderDto>
{
    public GetReaderDto GetReaderDto{ get; set; }
    public GetReaderQuery(GetReaderDto GetReaderDto) => this.GetReaderDto = GetReaderDto;
}

