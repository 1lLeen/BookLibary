using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsBooks.UpdateBook;

public class UpdateBookCommand : IRequest<GetBookDto>
{
    public UpdateBookDto UpdateBookDto { get; set; }
    public int Id { get; set; }
    public UpdateBookCommand(UpdateBookDto updateBookDto, int id) 
    {
        UpdateBookDto = updateBookDto;
        Id = id;
    }
}

