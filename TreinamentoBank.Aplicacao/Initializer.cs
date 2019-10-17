using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TreinamentoBank.Aplicacao.Features.Agencias;
using TreinamentoBank.Aplicacao.Features.Contas;
using TreinamentoBank.Aplicacao.Interfaces;

namespace TreinamentoBank.Aplicacao
{
    public static class Initializer
    {
        public static void StartAplication(this IServiceCollection services)
        {
            services.AddScoped<IAgenciaService, AgenciaService>();
            services.AddScoped<IContaService, ContaService>();
        }
    }
}
