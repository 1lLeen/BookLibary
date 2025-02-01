using LibaryAPI.Domain.DTOs.ReadersNewsletter;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IReaderNewsletterService:IAbstractService<GetReaderNewsletter, CreateReaderNewsletter, UpdateReaderNewsletter>
{
    Task<IEnumerable<GetReaderNewsletter>> GetReaderNewslettersAsync();
    Task<GetReaderNewsletter> GetReaderNewsletterByIdAsync(int id);
    Task<GetReaderNewsletter> CreateReaderNewsletterAsync(GetReaderNewsletter entity);
    Task<GetReaderNewsletter> UpdateReaderNewsletterAsync(int id, UpdateReaderNewsletter entity);
    Task<GetReaderNewsletter> DeleteReaderNewsletterAsync(int id);
}
