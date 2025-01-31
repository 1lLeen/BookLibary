using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Books;
public class CreateBookDto:BaseBookDto, ICreate
{
    public DateTime CreaetdTime { get; set; }
}

