using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
   public class ItensPedidoModel
    {
        public string Id { get; set; }
        public string IdProduto { get; set; }
        public string IdPedido { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        
    }
}
