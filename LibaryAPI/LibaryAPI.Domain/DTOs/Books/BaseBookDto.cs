using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Books;

public class BaseBookDto:IBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int CountPage { get; set; }
    public int Price { get; set; }
}

