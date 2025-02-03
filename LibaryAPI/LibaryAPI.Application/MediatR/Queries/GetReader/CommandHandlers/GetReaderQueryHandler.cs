using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        var entity = _repository.GetByIdAsync(command.Id);

        if (entity == null)
            throw new NotFoundException(nameof(command.Id), command);

        return _mapper.Map<GetReaderDto>(entity);
    }
}
