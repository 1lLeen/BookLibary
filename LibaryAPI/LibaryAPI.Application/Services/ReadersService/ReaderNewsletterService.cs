using AutoMapper;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces; 
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderNewsletterService : AbstractService<IReaderNewsletterRepository, ReaderNewsletterModel, GetReaderNewsletterDto, CreateReaderNewsletterDto, UpdateReaderNewsletterDto>,
    IReaderNewsletterService
{
    public ReaderNewsletterService(ILogger logger, IMapper mapper, IReaderNewsletterRepository repository) : base(logger, mapper, repository)
    {
    }
    
    public async Task<GetReaderNewsletterDto> UpdateReaderNewsletterAsync(int id,  UpdateReaderNewsletterDto update)
    {
        var model = await _repository.GetByIdAsync(id);
        
        model.ReturnDate = update.ReturnDate;
        model.DateOfReceipt = update.DateOfReceipt;
        model.IdReader = update.IdReader;
        model.IdBook = update.IdBook;

        var result = await _repository.UpdateAsync(model);
        return mapper.Map<GetReaderNewsletterDto>(result);
    }

    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersByReaderIdAsync(int readerId)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderNewsletterDto>>(result.Where(x => x.IdReader == readerId));
    }

    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersByBookIdAsync(int bookId)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderNewsletterDto>>(result.Where(x => x.IdBook == bookId));
    }

    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersDelayAsync()
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderNewsletterDto>>(result.Where(x => x.ReturnDate < DateTime.Now));
    }
}
