namespace LibaryAPI.Infrastructure.Models.Readers;
public class ReaderModel:BaseModel
{ 
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int AccountNumber { get; set; }
}

