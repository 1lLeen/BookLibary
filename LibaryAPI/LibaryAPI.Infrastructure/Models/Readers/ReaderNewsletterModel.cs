namespace LibaryAPI.Infrastructure.Models.Readers;
public class ReaderNewsletterModel:BaseModel
{ 
    public int IdBook { get; set; }
    public int IdReader { get; set; }
    public DateTime DateOfReceipt { get; set; }
    public DateTime ReturnDate { get; set; }
}
