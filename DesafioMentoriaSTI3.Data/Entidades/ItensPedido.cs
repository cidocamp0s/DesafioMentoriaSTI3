using DesafioMentoriaSTI3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Entidades
{
    public class ItensPedido
    {
        public string Id { get; set; }
        public string IdProduto { get; set; }
        public string IdPedido { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }      
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

    }
}
