using AutoMapper;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.BooksService;

public class BookService : AbstractService<IBookRepository, BookModel, IGet, ICreate, IUpdate>
{
    public BookService(ILogger logger, IMapper mapper, IBookRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<GetBookDto> GetBookByIdAsync(int id)
    {
        var book = await _repository.GetByIdAsync(id);
        return mapper.Map<GetBookDto>(book);
    }

    public async Task<IEnumerable<GetBookDto>> GetAllBooksAsync()
    {
        return mapper.Map<IEnumerable<GetBookDto>>(await _repository.GetAllAsync());
    }

    public async Task<GetBookDto> CreateBookAsync(CreateBookDto create)
    {
        var result = mapper.Map<GetBookDto>(await _repository.CreateAsync(mapper.Map<BookModel>(create)));
        return result;
    }

    public async Task<GetBookDto> UpdateBookAsync(int id, UpdateBookDto updateBookDto)
    {
        var book = await _repository.GetAsync(mapper.Map<BookModel>(updateBookDto));
        if(book != null)
        {
            book.Name = updateBookDto.Name;
            book.Description = updateBookDto.Description;
            book.Author = updateBookDto.Author;
            book.Publisher = updateBookDto.Publisher;
        }
        var result = mapper.Map<GetBookDto>(await _repository.UpdateAsync(book));
        return result;
    }

    public async Task<GetBookDto> DeleteBook(int id)
    {
        var book = await _repository.GetByIdAsync(id);
        var result = await _repository.DeleteAsync(book);
        return mapper.Map<GetBookDto>(result);
    }
}
