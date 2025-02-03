using LibaryAPI.Domain.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;

public class BaseReaderNewsletterDto:IBase
{
    [SwaggerSchema(ReadOnly = true)]
    public int Id { get; set; }
    public int IdBook { get; set; }
    public int IdReader { get; set; }
    public DateTime DateOfReceipt { get; set; }
    public DateTime ReturnDate { get; set; }
}

