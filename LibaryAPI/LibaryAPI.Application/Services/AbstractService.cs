using AutoMapper; 
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models; 
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.Logging; 

namespace LibaryAPI.Application.Services;

public class AbstractService<TRepository, TModel, TGet, TCreate, TUpdate>
    where TRepository : IAbstractRepository<TModel>
    where TModel : BaseModel
    where TGet : IGet
    where TCreate : ICreate
    where TUpdate : IUpdate
{
    protected readonly TRepository _repository;
    protected readonly ILogger logger;
    protected readonly IMapper mapper;

    public AbstractService(ILogger logger, IMapper mapper, TRepository repository)
    {
        _repository = repository;
        this.logger = logger;
        this.mapper = mapper;
    }
    public async Task<TGet> CreateAsync(TCreate entity)
    {
        var model = mapper.Map<TModel>(entity);
        await _repository.CreateAsync(model);
        model = await _repository.GetAsync(model);
        if(model != null)
            logger.LogInformation($"Created {model.Id}");
        var result = mapper.Map<TGet>(model);
        return result;
    }

    public async Task<TGet> DeleteAsync(int id)
    {
        var model = await _repository.GetAsync(mapper.Map<TModel>(await GetByIdAsync(id)));
        if (model == null)
        {
            logger.LogError($"not found with this ID:{id}");
            return mapper.Map<TGet>(model);
        }
        await _repository.DeleteAsync(model);
        var result = mapper.Map<TGet>(model); 
        logger.LogInformation($"Deleted {result}");
        return result;

    }

    public async Task<IEnumerable<TGet>> GetAllAsync()
    {
        var result = await _repository.GetAllAsync();
        logger.LogInformation($"Get all list {result}");
        return mapper.Map<IEnumerable<TGet>>(result);
    }

    public async Task<TGet> GetByIdAsync(int id)
    {
        var result = await _repository.GetAsync(mapper.Map<TModel>(await GetByIdAsync(id)));
        logger.LogInformation($"Id {id} and \n get {result}");
        return mapper.Map<TGet>(result);
    }

    public async Task<TGet> UpdateAsync(TUpdate entity)
    {
        var model = mapper.Map<TModel>(entity); 
        await _repository.UpdateAsync(model);
        logger.LogInformation($"model = {model}");
        model = mapper.Map<TModel>(await GetByIdAsync(model.Id));
        var result = mapper.Map<TGet>(model); 
        logger.LogInformation($"{model.UpdatedTime} - {model.Id}");
        return result;
    }
}
