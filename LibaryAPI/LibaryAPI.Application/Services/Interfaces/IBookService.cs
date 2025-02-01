using LibaryAPI.Domain.DTOs.Books;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IBookService:IAbstractService<GetBookDto, CreateBookDto, UpdateBookDto>
{
    Task<IEnumerable<GetBookDto>> GetBooksAsync();
    Task<GetBookDto> GetBookByIdAsync(int id);
    Task<GetBookDto> CreateBookAsync(CreateBookDto request);
    Task<GetBookDto> UpdateBookAsync(int id, UpdateBookDto request);
    Task<GetBookDto> DeleteBookAsync(string id);

}
