using DesafioMentoriaSTI3.Data.Context;
using System;
using System.Collections.Generic;

namespace DesafioMentoriaSTI3.Data.Entidades
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public string RazaoSocial { get; set; }
        public string Email { get; set; }

        //public List<Pedido> Pedido { get; set; }


    }
}
