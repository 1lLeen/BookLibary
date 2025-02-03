using AutoMapper;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces; 
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderNewsletterService : AbstractService<IReaderNewsletterRepository, ReaderNewsletterModel, GetReaderNewsletter, CreateReaderNewsletter, UpdateReaderNewsletter>,
    IReaderNewsletterService
{
    public ReaderNewsletterService(ILogger logger, IMapper mapper, IReaderNewsletterRepository repository) : base(logger, mapper, repository)
    {
    }
    
    public async Task<GetReaderNewsletter> UpdateReaderNewsletterAsync(int id,  UpdateReaderNewsletter update)
    {
        var model = await _repository.GetByIdAsync(id);
        
        model.ReturnDate = update.ReturnDate;
        model.DateOfReceipt = update.DateOfReceipt;
        model.IdReader = update.IdReader;
        model.IdBook = update.IdBook;

        var result = await _repository.UpdateAsync(model);
        return mapper.Map<GetReaderNewsletter>(result);
    }

    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersByReaderIdAsync(int readerId)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderNewsletter>>(result.Where(x => x.IdReader == readerId));
    }

    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersByBookIdAsync(int bookId)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderNewsletter>>(result.Where(x => x.IdBook == bookId));
    }

    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersDelayAsync()
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderNewsletter>>(result.Where(x => x.ReturnDate < DateTime.Now));
    }
}
