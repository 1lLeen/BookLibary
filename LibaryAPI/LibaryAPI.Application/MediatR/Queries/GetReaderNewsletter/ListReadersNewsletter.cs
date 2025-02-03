using LibaryAPI.Domain.DTOs.ReadersNewsletter;

namespace LibaryAPI.Application.MediatR.Queries.GetReaderNewsletter;

public class ListReadersNewsletter
{
    public IEnumerable<GetReaderNewsletterDto> ReadersNewsletter { get; set; }
}
