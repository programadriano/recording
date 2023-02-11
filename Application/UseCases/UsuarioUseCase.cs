using Application.Base;
using Application.Ports.Repository;
using Application.ViewModels;

namespace Application.UseCases
{
    public class UsuarioUseCase : IUsuarioUseCase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioUseCase(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<Guid> Add(UsuarioViewModel entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<UsuarioViewModel>> GetAll(int page, int qtd)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioViewModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UsuarioViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
