using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
    public class PedidoModel
    {
        public string Id { get; set; }
        public int numero { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataAlteracao { get; set; }
        public string status { get; set; }
        public decimal desconto { get; set; }
        public decimal frete { get; set; }
        public decimal subTotal { get; set; }
        public decimal valorTotal { get; set; }
        public ClienteModel  Cliente { get; set; }
        public EnderecoEntregaModel enderecoEntrega { get; set; }
        public List<ItensPedidoModel> itens { get; set; }
        public List<PagamentoModel> pagamento { get; set; }
    }





}

