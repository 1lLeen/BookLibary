using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetBook;

public class GetBookQuery : IRequest<GetBookDto>
{
    public int Id { get; set; }
    public GetBookQuery(int id) => Id = id;
}
