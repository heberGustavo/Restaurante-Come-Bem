using Microsoft.Extensions.DependencyInjection;
using RestauranteComeBem.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.CrossCutting.DependencyGroups
{
    public class DataDependencyInjection
    {
        public static void Register(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<SqlDataContext, SqlDataContext>();
            //serviceCollection.AddTransient<IFuncionarioArquivoRepository, FuncionarioArquivoRepository>();
        }
    }
}
