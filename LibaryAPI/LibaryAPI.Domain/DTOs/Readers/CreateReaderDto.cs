using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.Readers;

public class CreateReaderDto:BaseReaderDto, ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}
