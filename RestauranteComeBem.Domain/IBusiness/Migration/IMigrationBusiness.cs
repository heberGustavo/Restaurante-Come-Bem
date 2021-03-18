using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.Domain.IBusiness.Migration
{
    public interface IMigrationBusiness
    {
        bool ExecutarAtualizacaoBancoDados();
    }
}
