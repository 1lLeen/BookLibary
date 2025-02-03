using LibaryAPI.Application.MediatR.Commands.CommandsReaders.CreateReader;
using LibaryAPI.Application.MediatR.Commands.CommandsReaders.DeleteReader;
using LibaryAPI.Application.MediatR.Commands.CommandsReaders.UpdateReader;
using LibaryAPI.Application.MediatR.Queries.GetReader;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Readers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReaderMediatRController : ControllerBase
{
    protected readonly IReaderService _readerService;
    protected IMediator _mediator;
    private ILogger logger;
    

    public ReaderMediatRController(ILogger logger, IMediator mediator)
    { 
        _mediator = mediator;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderDto>> GetReadersAsync()
    {
        var result = await _mediator.Send(new GetReadersListQuery());
        logger.LogInformation($"Get {result.Readers.Count()} readers");
        return result.Readers;
    }

    [HttpGet("{id}")]
    public async Task<GetReaderDto> GetReaderByIdAsync(int id)
    {
        var result = await _mediator.Send(new GetReaderQuery(id));
        logger.LogInformation($"Get {result.Id}");
        return result;
    }

    [HttpPost]
    public async Task<GetReaderDto> CreateReaderAsync(CreateReaderDto create)
    {
        var result = await _mediator.Send(new CreateReaderCommand(create));
        logger.LogInformation($"Created {result.Id}");
        return result;
    }

    [HttpPut]
    public async Task<GetReaderDto> UpdateReaderAsync(int id, UpdateReaderDto update)
    {
        var result = await _mediator.Send(new UpdateReaderCommand(update, id));
        logger.LogInformation($"Updated: {update.Id}");
        return result;
    }

    [HttpDelete("{id}")]
    public async Task<GetReaderDto> DeleteReaderAsync(int id)
    {
        var result = await _mediator.Send(new DeleteReaderCommand(id));
        logger.LogInformation($"Deleted {result}");
        return result;
    }

}

