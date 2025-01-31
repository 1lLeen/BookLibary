using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;
public class GetReaderNewsletter:BaseReaderNewsletter, IGet
{
    public DateTime UpdatedTime { get; set; }
    public DateTime CreatedTime { get; set; }
}
