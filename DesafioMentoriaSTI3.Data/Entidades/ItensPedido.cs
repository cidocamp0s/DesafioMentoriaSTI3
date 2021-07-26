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

        [ForeignKey("Produto")]
        public Guid IdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }


        [ForeignKey("Pedido")]
        public Guid PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }


        //public virtual Produto Produto { get; set; }

    }
}
