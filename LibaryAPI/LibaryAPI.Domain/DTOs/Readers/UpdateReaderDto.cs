using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Readers;
public class UpdateReaderDto:BaseReaderDto, IUpdate
{
    public DateTime UpdatedTime { get; set; }
}
