using Microsoft.Extensions.DependencyInjection;
using GuideInvestimentos.Dominio.Interfaces.Servicos;
using GuideInvestimentos.Dominio.Servicos;
using GuideInvestimentos.Infra_Dados.Contextos;

namespace GuideInvestimentos.Infra.IoC
{
    public class IoCConfig
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddDbContext<GuideDbContext>();

            services.AddScoped<IAutorServico, AutorServico>();
        }
    }
}
