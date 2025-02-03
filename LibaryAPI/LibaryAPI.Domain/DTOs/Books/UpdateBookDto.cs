using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.Books;

public class UpdateBookDto:BaseBookDto,IUpdate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }
}
