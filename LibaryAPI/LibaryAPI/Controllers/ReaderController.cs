using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Readers;
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

[Route("api/[controller]")]
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

    [HttpGet]
    public async Task<GetReaderDto> GetReaderByIdAsync(int id)
    {
        return await _readerService.GetByIdAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderDto>> GetReadersByFullNameAsync(string fullName)
    {
        return await _readerService.GetReadersByFullNameAsync(fullName);
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderDto>> GetReadersByDateOfBirthAsync(DateTime date)
    {
        return await _readerService.GetReadersByDateOfBirthAsync(date);
    }

    [HttpPost]
    public async Task<GetReaderDto> CreateReaderAsync(CreateReaderDto create)
    {
        return await _readerService.CreateAsync(create);
    }

    [HttpPut]
    public async Task<GetReaderDto> UpdateReaderAsync(UpdateReaderDto update)
    {
        return await _readerService.UpdateAsync(update);
    }

    [HttpDelete]
    public async Task<GetReaderDto> DeleteReaderAsync(int id)
    {
        return await _readerService.DeleteAsync(id);
    }
}
