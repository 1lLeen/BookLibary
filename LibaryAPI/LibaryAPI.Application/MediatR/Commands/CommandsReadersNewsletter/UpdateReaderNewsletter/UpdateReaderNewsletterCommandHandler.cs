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
    AbstractCommandHandler<IReaderNewsletterRepository, UpdateReaderNewsletterCommand, ReaderNewsletterModel>,
    IRequestHandler<UpdateReaderNewsletterCommand, GetReaderNewsletterDto>
{
    public UpdateReaderNewsletterCommandHandler(IReaderNewsletterRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<GetReaderNewsletterDto> Handle(UpdateReaderNewsletterCommand command, CancellationToken cancellationToken)
    {
        var entity = await _repository.GetByIdAsync(command.Id);

        if (entity == null)
            throw new NotFoundException(nameof(UpdateBookDto), command.UpdateReaderNewsletterDto.Id);
        
        entity.IdReader = command.UpdateReaderNewsletterDto.IdReader;
        entity.IdBook = command.UpdateReaderNewsletterDto.IdBook;
        entity.ReturnDate = command.UpdateReaderNewsletterDto.ReturnDate;
        entity.DateOfReceipt = command.UpdateReaderNewsletterDto.DateOfReceipt;
        
        var result = await _repository.UpdateAsync(entity);

        return _mapper.Map<GetReaderNewsletterDto>(result);
    }
}
