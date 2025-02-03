using LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.CreateReaderNewsletter;
using LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.DeleteReaderNewsletter;
using LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.UpdateReaderNewsletter; 
using LibaryAPI.Application.MediatR.Queries.GetReaderNewsletter; 
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

/// <summary>
/// Контроллер с MediatR
/// </summary>

[Route("api/[controller]")]
[ApiController]
public class ReaderNewsletterMediatRController : ControllerBase
{
    protected IMediator _mediator;
    private ILogger logger;


    public ReaderNewsletterMediatRController(ILogger logger, IMediator mediator)
    { 
        _mediator = mediator;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<GetReaderNewsletterDto>> GetReadersNewsletterAsync()
    {
        var result = await _mediator.Send(new GetReadersNewsletterQuery());
        logger.LogInformation($"Get {result.ReadersNewsletter.Count()} readers");
        return result.ReadersNewsletter;
    }

    [HttpGet("{id}")]
    public async Task<GetReaderNewsletterDto> GetReaderNewletterByIdAsync(int id)
    {
        var result = await _mediator.Send(new GetReaderNewsletterQuery(id));
        logger.LogInformation($"Get {result.Id}");
        return result;
    }

    [HttpPost]
    public async Task<GetReaderNewsletterDto> CreateReaderNewsletterAsync(CreateReaderNewsletterDto create)
    {
        var result = await _mediator.Send(new CreateReaderNewsletterCommand(create));
        logger.LogInformation($"Created {result.Id}");
        return result;
    }

    [HttpPut]
    public async Task<GetReaderNewsletterDto> UpdateReaderNewsletterAsync(int id, UpdateReaderNewsletterDto update)
    {
        var result = await _mediator.Send(new UpdateReaderNewsletterCommand(id, update));
        logger.LogInformation($"Updated: {update.Id}");
        return result;
    }

    [HttpDelete("{id}")]
    public async Task<GetReaderNewsletterDto> DeleteReaderAsync(int id)
    {
        var result = await _mediator.Send(new DeleteReaderNewsletterCommand(id));
        logger.LogInformation($"Deleted {result}");
        return result;
    }
}
