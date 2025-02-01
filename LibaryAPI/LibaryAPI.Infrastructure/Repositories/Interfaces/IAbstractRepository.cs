using LibaryAPI.Infrastructure.Models;

namespace LibaryAPI.Infrastructure.Repositories.Interfaces;

public interface IAbstractRepository<TModel> where TModel : BaseModel
{
    Task<TModel> CreateAsync(TModel model);
    Task<TModel> UpdateAsync(TModel model);
    Task<TModel> DeleteAsync(TModel model);
    Task<TModel> GetAsync(TModel model);
    Task<IEnumerable<TModel>> GetAllAsync();
}
