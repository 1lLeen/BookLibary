using AutoMapper;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers;
using LibaryAPI.Infrastructure.Repositories;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderService : AbstractService<IReaderRepository, ReaderModel, IGet, ICreate, IUpdate>
{
    public ReaderService(ILogger logger, IMapper mapper, IReaderRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<IEnumerable<GetReaderDto>> GetReadersAsync()
    {
        return mapper.Map<IEnumerable<GetReaderDto>>(await _repository.GetAllAsync());
    }

    public async Task<GetReaderDto> GetReaderByIdAsyncd(int id)
    {
        return mapper.Map<GetReaderDto>(_repository.GetByIdAsync(id));
    }

    public async Task<GetReaderDto> CreateReaderAsync(CreateReaderDto create)
    {
        var reader = mapper.Map<ReaderModel>(create);
        var result = await _repository.CreateAsync(reader);
        return mapper.Map<GetReaderDto>(result);
    }

    public async Task<GetReaderDto> UpdateReaderAsync(int id, UpdateReaderDto update)
    {
        var reader = await _repository.GetByIdAsync(id);
        if(reader != null)
        {
            reader.FullName = update.FullName;
            reader.AccountNumber = update.AccountNumber;
            reader.DateOfBirth = update.DateOfBirth;
        }
        var result = mapper.Map<GetReaderDto>(await _repository.UpdateAsync(reader));
        return result;
    }

    public async Task<GetReaderDto> DeleteReaderAsync(int id)
    {
        var reader = mapper.Map<ReaderModel>(_repository.GetByIdAsync(id));
        var result = await _repository.DeleteAsync(reader);
        return mapper.Map<GetReaderDto>(result);
    }
}

