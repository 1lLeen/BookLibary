using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsBooks.UpdateBook;

public class UpdateBookCommand:IRequest<GetBookDto>
{
    public UpdateBookDto UpdateBookDto { get; set; }
}

