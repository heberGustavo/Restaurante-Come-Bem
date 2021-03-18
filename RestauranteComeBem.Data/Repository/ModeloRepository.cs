using AutoMapper;
using RestauranteComeBem.Data.EntityData;
using RestauranteComeBem.Data.Repository.Base;
using RestauranteComeBem.Domain.IRepository;
using RestauranteComeBem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.Data.Repository
{
    public class ModeloRepository : RepositoryBase<Modelo, ModeloData>, IModeloRepository
    {
        public ModeloRepository(SqlDataContext dataContext, IMapper mapper) : base(dataContext, mapper)
        {
        }
    }
}
