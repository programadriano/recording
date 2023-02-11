using Domain.Base;

namespace Domain.Entities
{
    public class Canal : IAggregateRoot
    {
        public string Nome { get; set; }

        public Canal(string nome)
        {
            Nome = nome;
        }
    }
}
