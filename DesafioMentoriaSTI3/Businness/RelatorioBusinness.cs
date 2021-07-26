using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{
    
    class RelatorioBusinness
    {
        private readonly DesafioContext _context;

        public RelatorioBusinness()
        {
            _context = new DesafioContext();
        }


        public List<RelatorioModel> ListaPedidosRelatorio()
        {
         var lista= _context.Pedidos.AsNoTracking().Select(p => new RelatorioModel
            {

                Numero = p.Numero,
                DataCriacao = p.DataCriacao,
                Cliente = _context.Clientes.AsNoTracking().Where(c => c.Id == p.Id).Select(c => c.Nome).ToString(),
                Status=p.Status,
                ValorTotal=p.ValorTotal

            }).ToList().OrderBy(x => x.Numero).ToList();

            return lista;
        }

    }
}
