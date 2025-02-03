using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsBooks.CreateBook;

public class CreateBookCommand:IRequest<GetBookDto>
{
    public CreateBookDto CreateBookDto { get; set; }
}
