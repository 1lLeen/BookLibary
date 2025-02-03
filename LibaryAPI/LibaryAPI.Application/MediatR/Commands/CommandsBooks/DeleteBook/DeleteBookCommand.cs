using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsBooks.DeleteBook;

public class DeleteBookCommand : IRequest<GetBookDto>
{
    public int Id { get; set; }
    public DeleteBookCommand(int id) => Id = id;
}
