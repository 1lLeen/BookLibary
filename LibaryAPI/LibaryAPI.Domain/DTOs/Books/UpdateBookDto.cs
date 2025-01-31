using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Books;

public class UpdateBookDto:BaseBookDto,IUpdate
{
    public DateTime UpdatedTime { get; set; }
}
