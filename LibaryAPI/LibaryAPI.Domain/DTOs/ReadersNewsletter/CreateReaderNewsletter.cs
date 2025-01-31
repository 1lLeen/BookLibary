using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;
public class CreateReaderNewsletter:BaseReaderNewsletter, ICreate
{
    public DateTime CreatedTime { get; set; }
}
