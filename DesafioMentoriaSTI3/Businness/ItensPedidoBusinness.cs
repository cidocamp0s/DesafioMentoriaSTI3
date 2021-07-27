using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{
    class ItensPedidoBusinness
    {
        private readonly DesafioContext _context;

        public ItensPedidoBusinness()
        {
            _context = new DesafioContext();

        }

        public void AdicionarItensPedido(ItensPedidoModel pedidoModel)
        {

            var itensPedido = new ItensPedido
            {
                Id = pedidoModel.Id, 
                //ProdutoId= pedidoModel.ProdutoId,
                Nome=_context.Produtos.AsNoTracking().Where(c => c.Id == pedidoModel.ProdutoId).Select(c => c.Nome).ToString(),
                //PedidoId =pedidoModel.PedidoId,
                Quantidade = pedidoModel.Quantidade        
                

            };

            _context.ItensPedidos.Add(itensPedido);
            _context.SaveChanges();






        }

    }
}
