using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Infrastructure;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibaryAPI.Application.MediatR.Commands.CommandsBooks.UpdateBook;

public class UpdateBookCommandHandler : AbstractCommandHandler<IBookRepository, UpdateBookCommand, BookModel>,
    IRequestHandler<UpdateBookCommand, GetBookDto>
{

    public UpdateBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _repository = bookRepository;
        _mapper = mapper;
    }

    public async Task<GetBookDto> Handle(UpdateBookCommand command, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(command.Id);

        if (entity == null)
            throw new NotFoundException(nameof(UpdateBookDto), command.UpdateBookDto.Id);


        entity.Name = command.UpdateBookDto.Name;
        entity.Author = command.UpdateBookDto.Author;
        entity.Publisher = command.UpdateBookDto.Publisher;
        entity.Description = command.UpdateBookDto.Description;
        entity.CountPage = command.UpdateBookDto.CountPage;
        entity.Price = command.UpdateBookDto.Price;

        var result = await _repository.UpdateAsync(entity);

        return _mapper.Map<GetBookDto>(result);
    }
}

