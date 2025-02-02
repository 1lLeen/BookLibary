using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;

namespace LibaryAPI.Infrastructure.Repositories;

public class ReaderNewsletterRepository : AbstractRepository<ReaderNewsletterModel>,IReaderNewsletterRepository
{
    public ReaderNewsletterRepository(LibaryDbContext context) : base(context)
    {
    }
}
