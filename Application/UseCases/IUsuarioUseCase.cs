using Application.Base;
using Application.ViewModels;

namespace Application.UseCases
{
    public interface IUsuarioUseCase
    {
        Task<UsuarioViewModel> GetById(Guid id);
        Task<Result<UsuarioViewModel>> GetAll(int page, int qtd);
        Task<Guid> Add(UsuarioViewModel entity);
        Task Update(UsuarioViewModel entity);
        Task DeleteAsync(Guid id);
    }
}
