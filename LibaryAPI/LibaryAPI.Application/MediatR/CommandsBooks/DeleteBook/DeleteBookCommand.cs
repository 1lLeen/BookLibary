using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.CommandsBooks.DeleteBook;

public class DeleteBookCommand:IRequest<GetBookDto>
{
    public int  Id { get; set; }
}
