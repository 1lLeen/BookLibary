namespace LibaryAPI.Infrastructure.Models.Readers;
public class ReadersModel:BaseModel
{ 
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int AccountNumber { get; set; }
}

