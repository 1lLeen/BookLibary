using AutoMapper;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Domain.DTOs.Readers;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models.Readers; 
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace LibaryAPI.Application.Services.ReadersService;

public class ReaderService : AbstractService<IReaderRepository, ReaderModel, GetReaderDto, CreateReaderDto, UpdateReaderDto>, IReaderService
{
    public ReaderService(ILogger logger, IMapper mapper, IReaderRepository repository) : base(logger, mapper, repository)
    {
    }

    public async Task<IEnumerable<GetReaderDto>> GetReadersByDateOfBirthAsync(DateTime date)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderDto>>(result.Where(x => x.DateOfBirth == date));
    }

    public async Task<IEnumerable<GetReaderDto>> GetReadersByFullNameAsync(string fullName)
    {
        var result = await _repository.GetAllAsync();
        return mapper.Map<IEnumerable<GetReaderDto>>(result.Where(x => x.FullName == fullName));
    }
}

