using LibaryAPI.Domain.DTOs.Readers;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IReaderService : IAbstractService<GetReaderDto, CreateReaderDto, UpdateReaderDto>
{
    Task<GetReaderDto> UpdateReaderAsync(int id, UpdateReaderDto update);
    Task<IEnumerable<GetReaderDto>> GetReadersByFullNameAsync(string fullName); 
}