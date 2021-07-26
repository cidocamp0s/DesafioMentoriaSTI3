using DesafioMentoriaSTI3.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Context
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public double Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Status { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorTotal { get; set; }

        public Guid ClienteId { get; set; }
        public Guid EnderecoEntregaId { get; set; }



        //public virtual Cliente Cliente { get; set; }
        //public virtual EnderecoEntrega EnderecoEntrega { get; set; }
        public virtual List<ItensPedido> Itens { get; set; }
        //public Pagamento Pagamento { get; set; }

    }
}
