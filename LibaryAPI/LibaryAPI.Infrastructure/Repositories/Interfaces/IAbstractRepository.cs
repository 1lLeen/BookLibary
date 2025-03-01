﻿using LibaryAPI.Infrastructure.Models;

namespace LibaryAPI.Infrastructure.Repositories.Interfaces;

public interface IAbstractRepository<TModel> where TModel : BaseModel
{
    Task<TModel> CreateAsync(TModel model);
    Task<TModel> UpdateAsync(TModel model);
    Task<TModel> DeleteAsync(TModel model); 
    Task<TModel?> GetByIdAsync(int id);
    Task<IEnumerable<TModel>> GetAllAsync();
}
