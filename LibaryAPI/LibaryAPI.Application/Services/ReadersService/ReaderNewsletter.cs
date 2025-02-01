using AutoMapper;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderNewsletter : AbstractService<IReaderNewsletterRepository, ReaderNewsletterModel, IGet, ICreate, IUpdate>
{
    public ReaderNewsletter(ILogger logger, IMapper mapper, IReaderNewsletterRepository repository) : base(logger, mapper, repository)
    {
    }
}
