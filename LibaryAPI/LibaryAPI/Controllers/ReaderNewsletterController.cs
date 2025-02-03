using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ReaderNewsletterController : ControllerBase
{
    protected readonly IReaderNewsletterService _readerNewsletterService;
    private ILogger logger;

    public ReaderNewsletterController(IReaderNewsletterService readerNewsletterService, ILogger logger)
    {
        _readerNewsletterService = readerNewsletterService;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersNewsletters()
    {
        return await _readerNewsletterService.GetAllAsync();
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersDelayAsync()
    {
        return await _readerNewsletterService.GetReadersDelayAsync();
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersByIdAsync(int id)
    {
        return await _readerNewsletterService.GetReadersByReaderIdAsync(id);
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<GetReaderNewsletter>> GetReadersByBookId(int id)
    {
        return await _readerNewsletterService.GetReadersByBookIdAsync(id);
    }

    [HttpPost] 
    public async Task<GetReaderNewsletter> CreateReaderNewsletter(CreateReaderNewsletter create)
    {
        return await _readerNewsletterService.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetReaderNewsletter> UpdateReaderNewsletter(int id, UpdateReaderNewsletter update)
    {
        return await _readerNewsletterService.UpdateReaderNewsletterAsync(id, update);
    }

    [HttpDelete("{id}")]
    public async Task<GetReaderNewsletter> DeleteReaderNewsletter(int id)
    {
        return await _readerNewsletterService.DeleteAsync(id);
    }
}
