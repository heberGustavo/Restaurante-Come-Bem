using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.CrossCutting.DependencyGroups
{
    public class DomainDependencyInjection
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<IFuncionarioArquivoBusiness, FuncionarioArquivoBusiness>();
        }
    }
}
