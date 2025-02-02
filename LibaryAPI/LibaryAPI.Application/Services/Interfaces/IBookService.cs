using LibaryAPI.Domain.DTOs.Books;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IBookService : IAbstractService<GetBookDto, CreateBookDto, UpdateBookDto>
{
    Task<IEnumerable<GetBookDto>> GetBooksByAuthorAsync(string author);
    Task<IEnumerable<GetBookDto>> GetBooksByPublisherAsync(string publisher);
}
