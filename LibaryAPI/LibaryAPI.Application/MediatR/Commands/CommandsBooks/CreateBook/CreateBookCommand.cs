using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsBooks.CreateBook;

public class CreateBookCommand : IRequest<GetBookDto>
{
    public CreateBookDto CreateBookDto { get; set; }
    public CreateBookCommand(CreateBookDto createBookDto) => CreateBookDto = createBookDto;
}
