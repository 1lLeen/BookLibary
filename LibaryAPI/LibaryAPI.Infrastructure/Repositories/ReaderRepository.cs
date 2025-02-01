using LibaryAPI.Infrastructure.Models.Readers;

namespace LibaryAPI.Infrastructure.Repositories;

public class ReaderRepository : AbstractRepository<ReaderModel>
{
    public ReaderRepository(LibaryDbContext context) : base(context)
    {
    }
}
