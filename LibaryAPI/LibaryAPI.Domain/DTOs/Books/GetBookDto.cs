using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.Books;

public class GetBookDto :BaseBookDto, IGet
{
    [SwaggerSchema(ReadOnly = true)]
    public DateTime CreatedTime { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime UpdatedTime { get; set; }

}

