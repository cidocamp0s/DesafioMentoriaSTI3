using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
   public class ItensPedidoModel
    {
        public Guid Id { get; set; }
        public Guid IdProduto { get; set; }
        public Guid IdPedido { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        
    }
}
