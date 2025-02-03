using LibaryAPI.Domain.DTOs.Books;
using MediatR;

namespace LibaryAPI.Application.MediatR.Queries.GetBook;

public class GetBooksListQuery : IRequest<ListBook>
{
}

