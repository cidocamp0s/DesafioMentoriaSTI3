using DesafioMentoriaSTI3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data
{
    public class Pagamento
    {
        public string Id { get; set; }
        public int Parcela { get; set; }
        public decimal Valor { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public Pedido Pedido { get; set; }
    }
}
