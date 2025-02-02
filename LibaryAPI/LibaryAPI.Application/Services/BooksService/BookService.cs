using AutoMapper;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.BooksService;

public class BookService : AbstractService<IBookRepository, BookModel, GetBookDto, CreateBookDto, UpdateBookDto>,
    IBookService
{
    public BookService(ILogger logger, IMapper mapper, IBookRepository repository) : base(logger, mapper, repository)
    {
    }
    public async Task<IEnumerable<GetBookDto>> GetBooksByAuthorAsync(int authorId)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetBookDto>>(result.Where(x => x.AuthorId == authorId));
    }

    public async Task<IEnumerable<GetBookDto>> GetBooksByPublisherAsync(string publisher)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetBookDto>>(result.Where(x => x.Publisher == publisher));
    }
}
