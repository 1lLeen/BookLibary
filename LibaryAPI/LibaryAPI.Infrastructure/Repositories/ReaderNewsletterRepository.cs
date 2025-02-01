using LibaryAPI.Infrastructure.Models.Readers;

namespace LibaryAPI.Infrastructure.Repositories;

public class ReaderNewsletterRepository : AbstractRepository<ReaderNewsletterModel>
{
    public ReaderNewsletterRepository(LibaryDbContext context) : base(context)
    {
    }
}
