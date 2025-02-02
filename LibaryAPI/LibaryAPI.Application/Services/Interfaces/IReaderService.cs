using LibaryAPI.Domain.DTOs.Readers;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IReaderService : IAbstractService<GetReaderDto, CreateReaderDto, UpdateReaderDto>
{
    Task<IEnumerable<GetReaderDto>> GetReadersByFullNameAsync(string fullName);
    Task<IEnumerable<GetReaderDto>> GetReadersByDateOfBirthAsync(DateTime date);
}