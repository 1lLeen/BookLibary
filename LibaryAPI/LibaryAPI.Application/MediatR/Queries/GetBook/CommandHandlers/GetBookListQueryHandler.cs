using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;
using System.Security.Cryptography.X509Certificates;

namespace LibaryAPI.Application.MediatR.Queries.GetBook;

public class GetBookListQueryHandler :
    AbstractCommandHandler<IBookRepository, GetBooksListQuery, GetBookDto, BookModel>,
    IRequestHandler<GetBooksListQuery, ListBook>
{
    public GetBookListQueryHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _repository = bookRepository;
        _mapper = mapper;
    }
    public override async Task<ListBook> Handle(GetBooksListQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.GetAllAsync();
        return new ListBook { ListBooks = _mapper.Map<IEnumerable<GetBookDto>>(result) };
    }
}
