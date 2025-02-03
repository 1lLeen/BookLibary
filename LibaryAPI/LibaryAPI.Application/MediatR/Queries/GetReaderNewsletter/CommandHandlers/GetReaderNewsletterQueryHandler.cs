using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetReaderNewsletter.CommandHandlers;
public class GetReaderNewsletterQueryHandler : 
    AbstractCommandHandler<IReaderNewsletterRepository, GetReaderNewsletterQuery, ReaderNewsletterModel>,
    IRequestHandler<GetReaderNewsletterQuery, GetReaderNewsletterDto>
{
    public GetReaderNewsletterQueryHandler(IReaderNewsletterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetReaderNewsletterDto> Handle(GetReaderNewsletterQuery command, CancellationToken token)
    {
        var entity = _repository.GetByIdAsync(command.Id);

        if (entity == null)
            throw new NotFoundException(nameof(command.Id), command);

        return _mapper.Map<GetReaderNewsletterDto>(entity);
    }
}

