using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsBooks.CreateBook;

public class CreateBookCommandHandler : AbstractCommandHandler<IBookRepository, CreateBookCommand, GetBookDto, BookModel>,
    IRequestHandler<CreateBookCommand, GetBookDto>
{
    public CreateBookCommandHandler(IBookRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public override async Task<GetBookDto> Handle(CreateBookCommand request, CancellationToken token)
    {
        var result = await _repository.CreateAsync(_mapper.Map<BookModel>(request.CreateBookDto));
        return _mapper.Map<GetBookDto>(result);
    }
}
