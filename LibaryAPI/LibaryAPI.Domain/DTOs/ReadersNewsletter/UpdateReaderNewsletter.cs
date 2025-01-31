using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;
public class UpdateReaderNewsletter:BaseReaderNewsletter, IUpdate
{
    public DateTime UpdatedTime { get; set; }
}
