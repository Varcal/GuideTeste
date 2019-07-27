using System.Linq;
using GuideInvestimentos.Dominio.ObjetosDeValor;

namespace GuideInvestimentos.Dominio.Extensions
{
    public static class NomeExtensions
    {
        public static string ABNTReferenciaAutor(this Nome nome)
        {
            var execoes = new[] { "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA", "JUNIOR" };

            var listaPalavras = nome.Texto.Split(' ').ToList();

            if (listaPalavras.Count == 1) return nome.Texto.ToUpper();

            string nomeFormatado;

            if (execoes.Contains(listaPalavras.Last().Trim().ToUpper()))
            {
                var excecao = listaPalavras.Last();
                listaPalavras.Remove(excecao);
                var sobrenome = listaPalavras.Last();
                listaPalavras.Remove(sobrenome);
                nomeFormatado = $"{sobrenome.ToUpper()} {excecao.ToUpper()}, ";
            }
            else
            {
                nomeFormatado = $"{listaPalavras.Last().ToUpper()}, ";
                listaPalavras.Remove(listaPalavras.Last());
            }

            return listaPalavras.Aggregate(nomeFormatado, (current, palavra) => current + $"{palavra} ").Trim();
        }
    }
}
