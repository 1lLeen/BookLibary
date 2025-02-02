using LibaryAPI.Domain.DTOs.Books;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IBookService : IAbstractService<GetBookDto, CreateBookDto, UpdateBookDto>
{
    Task<IEnumerable<GetBookDto>> GetBooksByAuthorAsync(int authorId);
    Task<IEnumerable<GetBookDto>> GetBooksByPublisherAsync(string publisher);
}
