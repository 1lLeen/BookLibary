using AutoMapper;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderService : AbstractService<IReaderRepository, ReaderModel, IGet, ICreate, IUpdate>
{
    public ReaderService(ILogger logger, IMapper mapper, IReaderRepository repository) : base(logger, mapper, repository)
    {
    }
}

