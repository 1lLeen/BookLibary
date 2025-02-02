using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;

public class GetReaderNewsletter:BaseReaderNewsletter, IGet
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
}
