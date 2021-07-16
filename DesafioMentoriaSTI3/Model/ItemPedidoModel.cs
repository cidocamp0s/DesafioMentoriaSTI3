using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
   public class ItemPedidoModel
    {
        public string IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
