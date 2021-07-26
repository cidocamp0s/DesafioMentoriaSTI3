using DesafioMentoriaSTI3.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Context
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public virtual List<ItensPedido> itensPedido { get; set; }
    }
}
