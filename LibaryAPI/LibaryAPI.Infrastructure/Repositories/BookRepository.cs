using LibaryAPI.Infrastructure.Models.Books;

namespace LibaryAPI.Infrastructure.Repositories;

public class BookRepository : AbstractRepository<BookModel>
{
    public BookRepository(LibaryDbContext context) : base(context)
    {
    }
}

