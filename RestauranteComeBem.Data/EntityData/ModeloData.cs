using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestauranteComeBem.Data.EntityData
{
    [Table("Modelo")]
    public class ModeloData
    {
        public int id_sorteio { get; set; }
        public string nome_sorteio { get; set; }
    }
}
