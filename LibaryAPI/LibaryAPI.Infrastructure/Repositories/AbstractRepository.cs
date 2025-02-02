using LibaryAPI.Infrastructure.Models;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace LibaryAPI.Infrastructure.Repositories;

public class AbstractRepository<TModel> : IAbstractRepository<TModel> where TModel : BaseModel
{
    protected LibaryDbContext _context;
    protected DbSet<TModel> _dbSet;
    public AbstractRepository(LibaryDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TModel>();
    }
    public async Task<TModel> CreateAsync(TModel model)
    {
        model.CreatedTime = DateTime.Now;
        model.UpdatedTime = DateTime.Now;
        await _dbSet.AddAsync(model);
        await _context.SaveChangesAsync();
        return model;
    }

    public async Task<TModel> DeleteAsync(TModel model)
    {
        _dbSet.Remove(model);
        await _context.SaveChangesAsync();
        return model;
    }

    public async Task<IEnumerable<TModel>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<TModel?> GetByIdAsync(int id)
    {
        return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<TModel> UpdateAsync(TModel model)
    {
        model.UpdatedTime = DateTime.Now;
        var entry = _dbSet.Entry(model);
        entry.State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return model;
    }
}
