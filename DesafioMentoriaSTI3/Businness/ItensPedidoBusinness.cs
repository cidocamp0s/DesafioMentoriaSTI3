using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
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
                IdProduto = pedidoModel.IdProduto,
                Quantidade = pedidoModel.Quantidade,
                PedidoId= pedidoModel.IdPedido
                

            };

            _context.ItensPedidos.Add(itensPedido);
            _context.SaveChanges();






        }

    }
}
