using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Readers;
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

/// <summary>
/// Контроллер без MediatR
/// </summary>

[Route("api/[controller]/[action]")]
[ApiController]
public class ReaderController : ControllerBase
{
    protected readonly IReaderService _readerService;
    private ILogger logger;

    public ReaderController(IReaderService readerService, ILogger logger)
    {
        _readerService = readerService;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderDto>> GetReadersAsync()
    {
        return await _readerService.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<GetReaderDto> GetReaderByIdAsync(int id)
    {
        return await _readerService.GetByIdAsync(id);
    }

    [HttpGet("{fullName}")]
    public async Task<IEnumerable<GetReaderDto>> GetReadersByFullNameAsync(string fullName)
    {
        return await _readerService.GetReadersByFullNameAsync(fullName);
    }

    [HttpPost]
    public async Task<GetReaderDto> CreateReaderAsync(CreateReaderDto create)
    {
        return await _readerService.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetReaderDto> UpdateReaderAsync(int id, UpdateReaderDto update)
    {
        return await _readerService.UpdateReaderAsync(id, update);
    }

    [HttpDelete("{id}")]
    public async Task<GetReaderDto> DeleteReaderAsync(int id)
    {
        return await _readerService.DeleteAsync(id);
    }
}
