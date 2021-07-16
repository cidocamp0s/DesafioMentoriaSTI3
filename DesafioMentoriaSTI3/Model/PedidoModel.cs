using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
    public class PedidoModel
    {
        public double Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Status { get; set; }
        public string TipoPagamento { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal SubTotal{ get; set; }
        public decimal ValorTotal { get; set; }
        public int Cliente { get; set; }
        public EnderecoEntrega EnderecoEntrega { get; set; }        
        public List<ItemPedidoModel> Itens { get; set; }
        public List<Pagamento> Pagamento { get; set; }




    }
}
