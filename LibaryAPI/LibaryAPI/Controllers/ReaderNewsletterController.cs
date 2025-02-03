using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

/// <summary>
/// Контроллер без MediatR
/// </summary>

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
    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersNewsletters()
    {
        return await _readerNewsletterService.GetAllAsync();
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersDelayAsync()
    {
        return await _readerNewsletterService.GetReadersDelayAsync();
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersByIdAsync(int id)
    {
        return await _readerNewsletterService.GetReadersByReaderIdAsync(id);
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersByBookId(int id)
    {
        return await _readerNewsletterService.GetReadersByBookIdAsync(id);
    }

    [HttpPost] 
    public async Task<GetReaderNewsletterDto> CreateReaderNewsletter(CreateReaderNewsletterDto create)
    {
        return await _readerNewsletterService.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetReaderNewsletterDto> UpdateReaderNewsletter(int id, UpdateReaderNewsletterDto update)
    {
        return await _readerNewsletterService.UpdateReaderNewsletterAsync(id, update);
    }

    [HttpDelete("{id}")]
    public async Task<GetReaderNewsletterDto> DeleteReaderNewsletter(int id)
    {
        return await _readerNewsletterService.DeleteAsync(id);
    }
}
