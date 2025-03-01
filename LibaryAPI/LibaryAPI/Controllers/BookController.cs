﻿using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Books;
using Microsoft.AspNetCore.Mvc; 

namespace LibaryAPI.Controllers;

/// <summary>
/// Контроллер без MediatR
/// </summary>

[Route("api/[controller]/[action]")] 
[ApiController]
public class BookController : ControllerBase
{
    protected readonly IBookService _bookService;
    private ILogger logger;

    public BookController(IBookService bookService, ILogger logger)
    {
        _bookService = bookService;
        this.logger = logger;
    }

    [HttpGet]    
    public async Task<IEnumerable<GetBookDto>> GetAllBooksAsync()
    {
        return await _bookService.GetAllAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<GetBookDto> GetBookById(int id)
    {
        return await _bookService.GetByIdAsync(id);
    }

    [HttpGet("{author}")]
    public async Task<IEnumerable<GetBookDto>> GetBooksByAuthorAsync(string author)
    {
        return await _bookService.GetBooksByAuthorAsync(author);
    }

    [HttpGet("{publisher}")]
    public async Task<IEnumerable<GetBookDto>> GetBooksByPublisherAsync(string publisher)
    {
        return await _bookService.GetBooksByPublisherAsync(publisher);
    }
    
    [HttpPost]
    public async Task<GetBookDto> CreateBookAsync(CreateBookDto create)
    {
        return await _bookService.CreateAsync(create);
    }

    [HttpPut("{id}")]
    public async Task<GetBookDto> UpdateBookAsync(int id, UpdateBookDto update)
    { 
        return await _bookService.UpdateBookAsync(id, update);
    }

    [HttpDelete("{id}")]
    public async Task<GetBookDto> DeleteBookAsync(int id)
    {
        return await _bookService.DeleteAsync(id);
    }
}
