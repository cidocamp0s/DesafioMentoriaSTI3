using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
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
                Numero = pedidoModel.numero,
                DataCriacao = pedidoModel.dataCriacao,
                DataAlteracao = pedidoModel.dataAlteracao,
                Status = pedidoModel.status,
                Desconto = pedidoModel.desconto,
                Frete = pedidoModel.frete,
                SubTotal = pedidoModel.subTotal,
                ValorTotal = pedidoModel.valorTotal,
                //Cliente = pedidoModel.Cliente,
                //Endereco_Entrega = pedidoModel.enderecoEntrega,
                //Itens = pedidoModel.itens,
                //Pagamento = pedidoModel.pagamento


            });

            _context.SaveChanges();

            
        }
    }
}
