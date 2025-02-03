using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.DeleteReaderNewsletter;

public class DeleteReadersNewsletterCommandHandler :
    AbstractCommandHandler<IReaderNewsletterRepository, DeleteReaderNewsletterCommand, GetReaderNewsletterDto, ReaderNewsletterModel>,
    IRequestHandler<DeleteReaderNewsletterCommand, GetReaderNewsletterDto>
{
    public DeleteReadersNewsletterCommandHandler(IReaderNewsletterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public override async Task<GetReaderNewsletterDto> Handle(DeleteReaderNewsletterCommand command, CancellationToken token)
    {
        var entity = await _repository.GetByIdAsync(command.Id);
        if (entity == null)
            throw new NotFoundException(nameof(BaseReaderNewsletterDto), command);

        var result = await _repository.DeleteAsync(entity);

        return _mapper.Map<GetReaderNewsletterDto>(result);
    }
}


