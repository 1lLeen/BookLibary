using AutoMapper;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers; 
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderService : AbstractService<IReaderRepository, ReaderModel, GetReaderDto, CreateReaderDto, UpdateReaderDto>,
    IReaderService
{
    public ReaderService(ILogger logger, IMapper mapper, IReaderRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<GetReaderDto> UpdateReaderAsync(int id,  UpdateReaderDto update)
    {
        var model = await _repository.GetByIdAsync(id);

        model.FullName = update.FullName;
        model.DateOfBirth = update.DateOfBirth;
        model.AccountNumber = update.AccountNumber;
        
        var result = await _repository.UpdateAsync(model);
        return mapper.Map<GetReaderDto>(result);
    }

    public async Task<IEnumerable<GetReaderDto>> GetReadersByFullNameAsync(string fullName)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderDto>>(result.Where(x => x.FullName == fullName));
    }
}

