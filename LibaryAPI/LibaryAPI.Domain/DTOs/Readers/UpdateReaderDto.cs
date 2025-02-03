using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.Readers;

public class UpdateReaderDto:BaseReaderDto, IUpdate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}
