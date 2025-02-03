using AutoMapper;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models; 
using LibaryAPI.Infrastructure.Repositories.Interfaces; 

namespace LibaryAPI.Application.MediatR.Abstract;

public abstract class AbstractCommandHandler<TRepository, TCommand, TModel>
    where TRepository : IAbstractRepository<TModel>
    where TModel : BaseModel
{
    protected TRepository _repository;
    protected IMapper _mapper;
}
