using Domain.Base;

namespace Domain.Entities
{
    public class RedeSocial : BaseEntity, IAggregateRoot
    {
        public RedeSocial(string nome, string uRL, string token)
        {
            Nome = nome;
            URL = uRL;
            Token = token;
        }

        public string Nome { get; set; }
        public string URL { get; set; }
        public string Token { get; set; }
    }
}
