using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.Readers;

public class BaseReaderDto:IBase
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int AccountNumber { get; set; }

}

