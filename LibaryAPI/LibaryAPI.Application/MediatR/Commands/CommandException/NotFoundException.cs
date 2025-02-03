namespace LibaryAPI.Application.MediatR.CommandsBooks.CommandException;

public class NotFoundException:Exception
{
    public NotFoundException(string message, object key):
        base($"Entity {message} ({key} not found)")
    { }
}
