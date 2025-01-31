
using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Readers;
public class GetReaderDto:BaseReaderDto, IGet
{
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }
}
