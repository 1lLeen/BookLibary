using LibaryAPI.Domain.DTOs.Books;

namespace LibaryAPI.Application.MediatR.Queries.GetBook;

public class ListBook
{
    public IEnumerable<GetBookDto> ListBooks { get; set; }
}
