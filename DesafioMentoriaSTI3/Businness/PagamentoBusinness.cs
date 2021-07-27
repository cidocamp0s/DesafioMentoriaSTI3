using DesafioMentoriaSTI3.Data;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{
    class PagamentoBusinness
    {


        private readonly DesafioContext _context;

        public PagamentoBusinness()
        {
            _context = new DesafioContext();
        }

        public void AdicionarPagamento(PagamentoModel pagamentoModel)
        {

            Pagamento pagamento = new Pagamento
            {
               Id = pagamentoModel.Id,
               Codigo=pagamentoModel.Codigo,
               Nome=pagamentoModel.Nome,
               Parcela=pagamentoModel.Parcela,
               Valor=pagamentoModel.Valor
               //,
               //PedidoId=pagamentoModel.PedidoId
              
            };


            if (_context.Pagamentos.Any(p => p.Id == pagamento.Id))
            {
                return;
            }
            else
            {
                _context.Pagamentos.Add(pagamento);
                _context.SaveChanges();
            }





        }
    }
}
