using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Infrastructure;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReaders.UpdateReader;

public class UpdateReaderCommandHandler : AbstractCommandHandler<IReaderRepository, UpdateReaderCommand, ReaderModel>,
    IRequestHandler<UpdateReaderCommand, GetReaderDto>
{
    public UpdateReaderCommandHandler(IReaderRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetReaderDto> Handle(UpdateReaderCommand command, CancellationToken token)
    {
        var entity = await _repository.GetByIdAsync(command.Id);

        if (entity == null)
            throw new NotFoundException(nameof(UpdateBookDto), command.UpdateReaderDto.Id);

        entity.FullName = command.UpdateReaderDto.FullName;
        entity.AccountNumber = command.UpdateReaderDto.AccountNumber;
        entity.DateOfBirth = command.UpdateReaderDto.DateOfBirth;

        var result = await _repository.UpdateAsync(entity);

        return _mapper.Map<GetReaderDto>(result);
    }
}
