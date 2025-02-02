using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;

public class CreateReaderNewsletter:BaseReaderNewsletter, ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}
