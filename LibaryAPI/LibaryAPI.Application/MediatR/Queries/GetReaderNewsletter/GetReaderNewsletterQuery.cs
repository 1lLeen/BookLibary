using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetReaderNewsletter;

public class GetReaderNewsletterQuery : IRequest<GetReaderNewsletterDto>
{
    public GetReaderNewsletterDto GetReaderNewsletterDto { get; set; }
    public GetReaderNewsletterQuery(GetReaderNewsletterDto getReaderNewsletterQueryDto) =>
        GetReaderNewsletterDto = getReaderNewsletterQueryDto;
}
