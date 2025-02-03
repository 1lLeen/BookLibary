using LibaryAPI.Application.MediatR.Commands.CommandsBooks.CreateBook;
using LibaryAPI.Application.MediatR.Commands.CommandsBooks.DeleteBook;
using LibaryAPI.Application.MediatR.Commands.CommandsBooks.UpdateBook; 
using LibaryAPI.Application.MediatR.Queries.GetBook; 
using LibaryAPI.Domain.DTOs.Books;
using MediatR; 
using Microsoft.AspNetCore.Mvc;

namespace LibaryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookMedatRController : ControllerBase
{ 
    protected IMediator _mediator;
    private ILogger logger;

    public BookMedatRController(ILogger logger, IMediator mediator)
    { 
        _mediator = mediator;
        this.logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<GetBookDto>> GetAllBooksAsync()
    {
        var result =  await _mediator.Send(new GetBooksListQuery());
        logger.LogInformation($"Get books: {result.ListBooks}");
        return result.ListBooks;
    }

    [HttpGet("{id}")]
    public async Task<GetBookDto> GetBookById(int id)
    {
        var result = await _mediator.Send(new GetBookQuery(id));
        logger.LogInformation($"Get book Id: {id}");
        return result;
    }

    [HttpPost]
    public async Task<GetBookDto> CreateBookAsync(CreateBookDto create)
    {
        var result = await _mediator.Send(new CreateBookCommand(create));
        logger.LogInformation($"Create book Id: {create.Name}");
        return result;
    }

    [HttpPut("{id}")]
    public async Task<GetBookDto> UpdateBookAsync(int id, UpdateBookDto update)
    {
        var result = await _mediator.Send(new UpdateBookCommand(update, id));
        logger.LogInformation($"{id} was updated");
        return result;
    }

    [HttpDelete("{id}")]
    public async Task<GetBookDto> DeleteBookAsync(int id)
    {
        var result = await _mediator.Send(new DeleteBookCommand(id));
        logger.LogInformation($"{id} deleted");
        return result;
    }
}

