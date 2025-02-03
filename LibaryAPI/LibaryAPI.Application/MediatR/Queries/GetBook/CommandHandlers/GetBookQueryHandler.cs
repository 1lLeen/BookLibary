using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetBook.CommandHandlers;

public class GetBookQueryHandler :
    AbstractCommandHandler<IBookRepository, GetBookQuery, BookModel>,
    IRequestHandler<GetBookQuery, GetBookDto>
{
    public GetBookQueryHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _repository = bookRepository;
        _mapper = mapper;
    }

    public async Task<GetBookDto> Handle(GetBookQuery query, CancellationToken token)
    {
        var entity = await _repository.GetByIdAsync(query.Id);

        if (entity == null)
            throw new NotFoundException(nameof(query.Id), query);

        return _mapper.Map<GetBookDto>(entity);
    }
}
