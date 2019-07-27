using FluentAssertions;
using GuideInvestimentos.Dominio.Extensions;
using GuideInvestimentos.Dominio.ObjetosDeValor;
using Xunit;

namespace GuideInvestimentos.Dominio.Testes.ObjetosDeValor
{
    public class NomeTestes
    {
        [Theory(DisplayName = "Formatar nome do autor")]
        [Trait("ObejtosDeValor", "Nome")]
        [InlineData("Varçal", "VARÇAL")]
        [InlineData("Carlos Drummond de Andrade", "ANDRADE, Carlos Drummond de")]
        [InlineData("João da Silva", "SILVA, João da")]
        [InlineData("Maria das Neves", "NEVES, Maria das")]
        [InlineData("Cleber Varçal", "VARÇAL, Cleber")]
        [InlineData("José Silva Neto", "SILVA NETO, José")]
        [InlineData("André Luis da Silva Neto", "SILVA NETO, André Luis da")]
        [InlineData("Ulisses Ezequiel Junior", "EZEQUIEL JUNIOR, Ulisses")]

        public void Formatar_nome_de_autor(string nomeAutor, string nomeEsperado)
        {
            var nome = new Nome(nomeAutor);

            nome.ABNTReferenciaAutor().Should().Be(nomeEsperado);
        }
    }
}
