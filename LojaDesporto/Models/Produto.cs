using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaDesporto.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public string Descricao { get; set; }

    }
}
