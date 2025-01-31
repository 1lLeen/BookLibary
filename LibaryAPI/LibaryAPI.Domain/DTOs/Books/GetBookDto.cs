using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Books;

public class GetBookDto :BaseBookDto, IGet
{
    public DateTime CreatedTime { get; set; }
    public DateTime UpdatedTime { get; set; }

}

