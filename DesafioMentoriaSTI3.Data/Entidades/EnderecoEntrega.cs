﻿using DesafioMentoriaSTI3.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Data.Entidades
{
    public class EnderecoEntrega
    { 
        public string Id { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }
        public List<Pedido> Pedido { get; set; }

       
    }
}