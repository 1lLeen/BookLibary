using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.Readers;

public class BaseReaderDto:IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int AccountNumber { get; set; }

}

