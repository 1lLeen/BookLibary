using AutoMapper;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Routing.Matching;

namespace LibaryAPI.Application.MediatR.CommandsReadersNewsletter.CreateReaderNewsletter;

public class CreateReaderNewsletterCommandHandler : 
    AbstractCommandHandler<IReaderNewsletterRepository, CreateReaderNewsletterCommand, GetReaderNewsletterDto, ReaderNewsletterModel>,
    IRequestHandler<CreateReaderNewsletterCommand, GetReaderNewsletterDto>
{
    public CreateReaderNewsletterCommandHandler(IReaderNewsletterRepository readerNewsletterRepository, IMapper mapper)
    {
        _repository = readerNewsletterRepository;
        _mapper = mapper;
    }

    public override async Task<GetReaderNewsletterDto> Handle(CreateReaderNewsletterCommand command, CancellationToken cancellationToken)
    {
        var result = await _repository.CreateAsync(_mapper.Map<ReaderNewsletterModel>(command.CreateReaderNewsletterDto));
        return _mapper.Map<GetReaderNewsletterDto>(result);
    }
}
