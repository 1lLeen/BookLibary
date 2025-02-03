using LibaryAPI.Domain.DTOs.Readers;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibaryAPI.Application.MediatR.Queries.GetReader;

public class GetReaderQuery : IRequest<GetReaderDto>
{
    public int Id { get; set; }
    public GetReaderQuery(int id) => Id = id;
}

