using DesafioMentoriaSTI3.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Model
{
    class RelatorioModel
    {

        public Guid Id { get; set; }
        public string Cliente { get; set; }
        public double Numero { get; set; }
        public DateTime DataCriacao { get; set; } 
        public DateTime DataAlteracao { get; set; }
        public string Status { get; set; }
        public decimal Desconto { get; set; }
        public decimal Frete { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Selecionado { get; set; }






    }
}
