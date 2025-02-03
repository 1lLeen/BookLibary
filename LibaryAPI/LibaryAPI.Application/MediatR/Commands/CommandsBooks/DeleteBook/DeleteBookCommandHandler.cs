using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Infrastructure;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LibaryAPI.Application.MediatR.Commands.CommandsBooks.DeleteBook;

public class DeleteBookCommandHandler : AbstractCommandHandler<IBookRepository, DeleteBookCommand, GetBookDto, BookModel>,
    IRequestHandler<DeleteBookCommand, GetBookDto>
{
    public DeleteBookCommandHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _repository = bookRepository;
        _mapper = mapper;
    }

    public override async Task<GetBookDto> Handle(DeleteBookCommand command, CancellationToken token)
    {
        var entity = await _repository.GetByIdAsync(command.Id);
        if (entity == null)
            throw new NotFoundException(nameof(BaseBookDto), command);

        var result = await _repository.DeleteAsync(entity);

        return _mapper.Map<GetBookDto>(result);
    }
}
