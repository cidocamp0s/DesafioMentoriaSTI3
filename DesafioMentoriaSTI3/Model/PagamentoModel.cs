﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
    public class PagamentoModel
    {
        public Guid Id { get; set; }
        public int Parcela { get; set; }
        public decimal Valor { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public Guid PedidoId { get; set; }

    }
}
