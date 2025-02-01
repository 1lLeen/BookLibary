using LibaryAPI.Domain.DTOs.Readers;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IReaderService:IAbstractService<GetReaderDto, CreateReaderDto, UpdateReaderDto>
{
    Task<GetReaderDto> GetReadersAsync();
    Task<GetReaderDto> GetReaderByIdAsync(int id);
    Task<CreateReaderDto> CreateReaderAsync(CreateReaderDto entity);
    Task<UpdateReaderDto> UpdateReaderAsync(int id, UpdateReaderDto entity);
    Task<GetReaderDto> DeleteReaderAsync(int id);
}