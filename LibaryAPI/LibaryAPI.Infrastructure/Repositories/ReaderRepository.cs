using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;

namespace LibaryAPI.Infrastructure.Repositories;

public class ReaderRepository : AbstractRepository<ReaderModel>,IReaderRepository
{
    public ReaderRepository(LibaryDbContext context) : base(context)
    {
    }
}
