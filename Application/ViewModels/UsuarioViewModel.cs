using Domain.Entities.ValueObjects;

namespace Application.ViewModels
{
    public class UsuarioViewModel
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public CPF CPF { get; private set; }
        public Endereco Endereco { get; private set; }
    }
}
