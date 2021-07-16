using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
    public class ClienteModel
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }    
        public string RazaoSocial { get; set; }
        public string Email { get; set; }       
        public EnderecoEntrega EnderecoEntrega { get; set; }

    }
}
