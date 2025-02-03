using LibaryAPI.Domain.DTOs.Readers;

namespace LibaryAPI.Application.MediatR.Queries.GetReader;

public class ListReaders
{
    public IEnumerable<GetReaderDto> Readers { get; set; }
}
