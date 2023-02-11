using Application.Base;
using Application.Ports.Repository;
using Domain.Entities;

namespace Infra.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<Guid> Add(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Usuario id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Usuario>> GetAll(int page, int qtd)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
