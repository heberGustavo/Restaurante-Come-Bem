using Microsoft.Extensions.DependencyInjection;
using RestauranteComeBem.Domain.IBusiness.Migration;
using RestauranteComeBem.Migration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.CrossCutting.DependencyGroups
{
    public class DomainDependencyInjection
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMigrationBusiness, MigrationBusiness>();

            //serviceCollection.AddTransient<IFuncionarioArquivoBusiness, FuncionarioArquivoBusiness>();
        }
    }
}
