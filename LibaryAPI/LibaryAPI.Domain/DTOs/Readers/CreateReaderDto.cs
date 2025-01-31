using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Readers;
public class CreateReaderDto:BaseReaderDto, ICreate
{
    public DateTime CreatedTime { get; set; }
}
