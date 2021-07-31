using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
    public class PedidoModel
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



        public ClienteModel Cliente { get; set; }
        public EnderecoEntregaModel EnderecoEntrega { get; set; }
        public List<ItensPedidoModel> Itens { get; set; }
        public List<PagamentoModel> Pagamento { get; set; }
    }





}

