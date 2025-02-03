using LibaryAPI.Domain.Interfaces;

namespace LibaryAPI.Application.Services.Interfaces;

public interface IAbstractService<TGet, TCreate, TUpdate> 
    where TGet : IGet
    where TCreate : ICreate
    where TUpdate : IUpdate
{
    Task<IEnumerable<TGet>> GetAllAsync();
    Task<TGet> GetByIdAsync(int id);
    Task<TGet> CreateAsync(TCreate entity);
    Task<TGet> UpdateAsync(TUpdate entity);
    Task<TGet> DeleteAsync(int id);
}
