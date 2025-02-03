using AutoMapper;
using LibaryAPI.Application.MediatR.Abstract;
using LibaryAPI.Application.MediatR.CommandException;
using LibaryAPI.Domain.DTOs.Books;
using LibaryAPI.Domain.DTOs.ReadersNewsletter;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR.Commands.CommandsReadersNewsletter.UpdateReaderNewsletter;

public class UpdateReaderNewsletterCommandHandler :
    AbstractCommandHandler<IReaderNewsletterRepository, UpdateReaderNewsletterCommand, GetReaderNewsletterDto, ReaderNewsletterModel>,
    IRequestHandler<UpdateReaderNewsletterCommand, GetReaderNewsletterDto>
{
    public UpdateReaderNewsletterCommandHandler(IReaderNewsletterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public override async Task<GetReaderNewsletterDto> Handle(UpdateReaderNewsletterCommand command, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(command.UpdateReaderNewsletterDto.Id);

        if (entity == null)
            throw new NotFoundException(nameof(UpdateBookDto), command.UpdateReaderNewsletterDto.Id);

        var result = await _repository.UpdateAsync(entity);

        return _mapper.Map<GetReaderNewsletterDto>(result);
    }
}
