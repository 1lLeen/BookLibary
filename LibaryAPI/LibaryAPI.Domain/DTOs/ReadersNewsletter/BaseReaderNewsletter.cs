using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Domain.DTOs.ReadersNewsletter;
public class BaseReaderNewsletter:IBase
{
    public int Id { get; set; }
    public int IdBook { get; set; }
    public int IdReader { get; set; }
    public DateTime DateOfReceipt { get; set; }
    public DateTime ReturnDate { get; set; }
}

