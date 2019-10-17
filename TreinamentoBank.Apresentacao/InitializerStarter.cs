using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using TreinamentoBank.Aplicacao;
using TreinamentoBank.Infra.Memory;

namespace TreinamentoBank.Apresentacao
{
    public static class InitializerStarter
    {
        public static ServiceProvider Start()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.StartDao();
            serviceCollection.StartAplication();

            ServiceProvider services = serviceCollection.BuildServiceProvider();

            return services;
        }

    }
}
