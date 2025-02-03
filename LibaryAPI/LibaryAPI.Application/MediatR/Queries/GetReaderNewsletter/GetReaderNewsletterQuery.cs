using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetReaderNewsletter;

public class GetReaderNewsletterQuery : IRequest<GetReaderNewsletterDto>
{
    public int Id { get; set; }
    public GetReaderNewsletterQuery(int id) => Id = id;
}
