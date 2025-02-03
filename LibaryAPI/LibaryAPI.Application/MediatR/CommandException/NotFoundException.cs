namespace LibaryAPI.Application.MediatR.CommandException;

public class NotFoundException : Exception
{
    public NotFoundException(string message, object key) :
        base($"Entity {message} ({key} not found)")
    { }
}
