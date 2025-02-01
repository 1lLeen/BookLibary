using AutoMapper;
using LibaryAPI.Application.Services.Interfaces;
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

}
