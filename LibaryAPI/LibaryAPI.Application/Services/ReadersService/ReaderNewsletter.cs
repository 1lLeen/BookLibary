using AutoMapper;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderNewsletter : AbstractService<IReaderNewsletterRepository, ReaderNewsletterModel, IGet, ICreate, IUpdate>
{
    public ReaderNewsletter(ILogger logger, IMapper mapper, IReaderNewsletterRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersNewsletterAsync()
    {
        return mapper.Map<IEnumerable<GetReaderNewsletter>>(await _repository.GetAllAsync());
    }

    public async Task<GetReaderNewsletter> GetReaderNewsletterByIdAsync(int id)
    {
        return mapper.Map<GetReaderNewsletter>(await _repository.GetByIdAsync(id));
    }

    public async Task<GetReaderNewsletter> CreateReaderNewsletterAsync(CreateReaderNewsletter create)
    {
        var readerNewsletter = mapper.Map<ReaderNewsletterModel>(create);
        var result = await _repository.CreateAsync(readerNewsletter);
        return mapper.Map<GetReaderNewsletter>(result);
    }

    public async Task<GetReaderNewsletter> UpdateReaderNewsletterAsync(int id, UpdateReaderNewsletter update)
    {
        var readerNewsletter = await _repository.GetByIdAsync(id);
        if (readerNewsletter != null)
        {
            readerNewsletter.ReturnDate = update.ReturnDate;
            readerNewsletter.DateOfReceipt = update.DateOfReceipt;
            readerNewsletter.IdReader = update.IdReader;
            readerNewsletter.IdBook = update.IdBook;
        }
        var result = await _repository.UpdateAsync(readerNewsletter);
        return mapper.Map<GetReaderNewsletter>(result);
    }

    public async Task<GetReaderNewsletter> DeleteReaderNewsletterAsync(int id)
    {
        var readerNewsletter = await _repository.GetByIdAsync(id);
        var result = _repository.DeleteAsync(readerNewsletter);
        return mapper.Map<GetReaderNewsletter>(result);
    }
}
