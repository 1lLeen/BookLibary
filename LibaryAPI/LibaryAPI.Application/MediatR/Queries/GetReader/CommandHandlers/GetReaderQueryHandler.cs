using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetReader.CommandHandlers;

public class GetReaderQueryHandler :
    AbstractCommandHandler<IReaderRepository, GetReaderQuery, ReaderModel>,
    IRequestHandler<GetReaderQuery, GetReaderDto>
{
    public GetReaderQueryHandler(IReaderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetReaderDto> Handle(GetReaderQuery command, CancellationToken cancellationToken)
    {
        var result = _repository.GetAllAsync();
        return _mapper.Map<GetReaderDto>(result);
    }
}
