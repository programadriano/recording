using Application.Base;
using Domain.Base;

namespace Application.Ports.Repository
{
    public interface IRepository<T> : IAggregateRoot
    {
        Task<T> GetById(Guid id);
        Task<Result<T>> GetAll(int page, int qtd);
        Task<Guid> Add(T entity);
        Task Update(T entity);
        Task Delete(T id);
    }
}
