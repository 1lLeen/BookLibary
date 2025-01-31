using System.Globalization;

namespace LibaryAPI.Domain.DTOs;

public class DtoReader
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int AccountNumber { get; set; }
}

