using Domain.Base;
using Domain.Entities;
using Domain.Entities.ValueObjects;

namespace Domain.Tests.Entities
{
    public class UsuarioTests
    {
        [Fact(DisplayName = "Validando cadastro de um novo usuario com nome em vazio deve gerar exception")]
        [Trait("Categoria", "Usuario")]
        public void Should_Validate_If_Name_Is_Empty()
        {
            //Arrange & Act
            var result = Assert.Throws<DomainException>(() => new Usuario("", "tadriano.net@gmail.com", "", new CPF("31672800855"), new Endereco("Rua x", "complemento Y", "bairro", "cidade x", "estado", "00000000")));

            //Assert
            Assert.Equal("O nome não pode estar vazio!", result.Message);
        }

        [Fact(DisplayName = "Validando cadastro de um novo usuario com email em vazio deve gerar exception")]
        [Trait("Categoria", "Usuario")]
        public void Should_Validate_If_Email_Is_Empty()
        {
            //Arrange & Act
            var result = Assert.Throws<DomainException>(() => new Usuario("Thiago S Adriano", "", "", new CPF("31672800855"), new Endereco("Rua x", "complemento Y", "bairro", "cidade x", "estado", "00000000")));

            //Assert
            Assert.Equal("O email não pode estar vazio!", result.Message);
        }

    }
}
