using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Infrastructure;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReaders.DeleteReader;

public class DeleteReaderCommandHandler : AbstractCommandHandler<IReaderRepository, DeleteReaderCommand, GetReaderDto, ReaderModel>,
    IRequestHandler<DeleteReaderCommand, GetReaderDto>
{
    public DeleteReaderCommandHandler(IReaderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public override async Task<GetReaderDto> Handle(DeleteReaderCommand command, CancellationToken token)
    {
        var entity = await _repository.GetByIdAsync(command.Id);

        if (entity == null)
            throw new NotFoundException(nameof(BaseReaderDto), command);

        var result = await _repository.DeleteAsync(entity);

        return _mapper.Map<GetReaderDto>(result);
    }
}
