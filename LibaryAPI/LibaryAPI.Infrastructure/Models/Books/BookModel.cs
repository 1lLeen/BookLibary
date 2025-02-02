namespace LibaryAPI.Infrastructure.Models.Books;
public class BookModel:BaseModel
{ 
    public string Name { get; set; }
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public string Publisher { get; set; }
    public int CountPage { get; set; }
    public int Price { get; set; }
}
