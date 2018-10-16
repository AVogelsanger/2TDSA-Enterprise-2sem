using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.NAC.Correcao.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string  Nome { get; set; }
        public IList<Bicicleta> Bicicletas { get; set; }
    }
}