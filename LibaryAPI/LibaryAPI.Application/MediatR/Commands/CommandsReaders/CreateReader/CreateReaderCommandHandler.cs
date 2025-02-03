using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Infrastructure;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReaders.CreateReader;

public class CreateReaderCommandHandler : AbstractCommandHandler<IReaderRepository, CreateReaderCommand, ReaderModel>,
    IRequestHandler<CreateReaderCommand, GetReaderDto>
{
    public CreateReaderCommandHandler(IReaderRepository readerRepository, IMapper mapper)
    {
        _repository = readerRepository;
        _mapper = mapper;
    }

    public async Task<GetReaderDto> Handle(CreateReaderCommand command, CancellationToken token)
    {
        var result = await _repository.CreateAsync(_mapper.Map<ReaderModel>(command.CreateReaderDto));
        return _mapper.Map<GetReaderDto>(result);
    }
}
