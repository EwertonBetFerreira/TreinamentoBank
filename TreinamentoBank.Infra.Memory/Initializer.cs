using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TreinamentoBank.Dominio.Interfaces;
using TreinamentoBank.Infra.Memory.Features.Agencias;
using TreinamentoBank.Infra.Memory.Features.Contas;

namespace TreinamentoBank.Infra.Memory
{
    public static class Initializer
    {
        public static void StartDao(this IServiceCollection services)
        {
            services.AddScoped<IAgenciaRepository, AgenciaDao>();
            services.AddScoped<IContaRepository, ContaDao>();

        }
    }
}
