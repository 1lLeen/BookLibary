using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetReader.CommandHandlers;

public class GetReaderListQueryHandler : 
    AbstractCommandHandler<IReaderRepository,  GetReadersListQuery, ReaderModel>,
    IRequestHandler<GetReadersListQuery, ListReaders>
{
    public GetReaderListQueryHandler(IReaderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ListReaders> Handle(GetReadersListQuery command, CancellationToken token)
    {
        var result = await _repository.GetAllAsync();
        return new ListReaders {Readers = _mapper.Map<IEnumerable<GetReaderDto>>(result)};
    }
}
