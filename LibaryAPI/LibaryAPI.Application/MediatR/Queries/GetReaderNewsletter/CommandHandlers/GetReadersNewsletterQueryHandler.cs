using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetReaderNewsletter.CommandHandlers;
public class GetReadersNewsletterQueryHandler :
    AbstractCommandHandler<IReaderNewsletterRepository, GetReadersNewsletterQuery, ReaderNewsletterModel>,
    IRequestHandler<GetReadersNewsletterQuery, ListReadersNewsletter>
{
    public GetReadersNewsletterQueryHandler(IReaderNewsletterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ListReadersNewsletter> Handle(GetReadersNewsletterQuery command, CancellationToken token)
    {
        var result = _repository.GetAllAsync();
        return new ListReadersNewsletter { ReadersNewsletter = _mapper.Map<IEnumerable<GetReaderNewsletterDto>>(result) };
    }
}
