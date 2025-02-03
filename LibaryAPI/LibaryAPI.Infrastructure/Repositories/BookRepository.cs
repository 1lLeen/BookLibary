using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;

namespace LibaryAPI.Infrastructure.Repositories;

public class BookRepository : AbstractRepository<BookModel>,IBookRepository
{
    public BookRepository(LibaryDbContext context) : base(context)
    {
    }
}

