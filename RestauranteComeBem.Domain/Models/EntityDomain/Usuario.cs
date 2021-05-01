using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteComeBem.Domain.Models.EntityDomain
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
    }
}
