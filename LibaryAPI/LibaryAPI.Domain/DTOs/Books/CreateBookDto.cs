using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.Books;
public class CreateBookDto:BaseBookDto, ICreate
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreaetdTime { get; set; }
}

