using DesafioMentoriaSTI3.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Entidades
{
    public class ItensPedido
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public Guid ProdutoId { get; set; }
        public Guid PedidoId { get; set; }

        public Pedido Pedido { get; set; }


    }
}
