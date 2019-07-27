using System;
using System.Collections.Generic;
using System.Text;
using GuideInvestimentos.Dominio.Entidades;
using GuideInvestimentos.Dominio.Interfaces.Repositorios;

namespace GuideInvestimentos.Infra_Dados.Repositorios
{
    public sealed class AutorRepositorio : IAutorRepositorio
    {
        public IReadOnlyList<Autor> SelecionarAutoresPorQuantidade(int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
