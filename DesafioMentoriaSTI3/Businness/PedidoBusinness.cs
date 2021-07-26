using DesafioMentoriaSTI3.Data;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DesafioMentoriaSTI3.Businness
{
    class PedidoBusinness
    {
        private readonly DesafioContext _context;

        public PedidoBusinness()
        {
            _context = new DesafioContext();
        }

        public void AdicionarPedido(PedidoModel pedidoModel)
        {

            _context.Pedidos.Add(new Pedido
            {

                Id = pedidoModel.Id,
                Numero = pedidoModel.Numero,
                DataCriacao = pedidoModel.DataCriacao,
                DataAlteracao = pedidoModel.DataAlteracao,
                Status = pedidoModel.Status,
                Desconto = pedidoModel.Desconto,
                Frete = pedidoModel.Frete,
                SubTotal = pedidoModel.SubTotal,
                ValorTotal = pedidoModel.ValorTotal,
                ClienteId = pedidoModel.cliente.Id,
                EnderecoEntregaId = pedidoModel.EnderecoEntrega.Id

            });

            _context.SaveChanges();

        }


        public List<PedidoModel> ListarPedidos()
        {
            return _context.Pedidos.AsNoTracking().Select(p => new PedidoModel
            {
              
                Numero=p.Numero,
                DataCriacao=p.DataCriacao
                
                
               
            }).ToList().OrderBy(x => x.Numero).ToList();
        }

    }
}
