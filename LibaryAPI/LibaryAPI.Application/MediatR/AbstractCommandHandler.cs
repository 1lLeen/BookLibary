using AutoMapper;
using LibaryAPI.Domain.Interfaces;
using LibaryAPI.Infrastructure.Models;
using LibaryAPI.Infrastructure.Repositories;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using MediatR;

namespace LibaryAPI.Application.MediatR;

public abstract class AbstractCommandHandler<TRepository, TCommand, TGet, TModel>
    where TRepository : IAbstractRepository<TModel>
    where TModel : BaseModel
    where TGet : IGet
    where TCommand : IRequest<TGet>
{
    protected TRepository _repository;
    protected IMapper _mapper;
    public abstract Task<TGet> Handle(TCommand command, CancellationToken cancellationToken);
}
