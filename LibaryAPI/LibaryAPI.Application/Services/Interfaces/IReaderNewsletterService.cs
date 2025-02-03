using LibaryAPI.Domain.DTOs.ReadersNewsletter;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IReaderNewsletterService : IAbstractService<GetReaderNewsletterDto, CreateReaderNewsletterDto, UpdateReaderNewsletterDto>
{
    Task<GetReaderNewsletterDto> UpdateReaderNewsletterAsync(int id, UpdateReaderNewsletterDto updatel);
    Task<IEnumerable<GetReaderNewsletterDto>> GetReadersDelayAsync();
    Task<IEnumerable<GetReaderNewsletterDto>> GetReadersByReaderIdAsync(int readerId);
    Task<IEnumerable<GetReaderNewsletterDto>> GetReadersByBookIdAsync(int bookId);
}
