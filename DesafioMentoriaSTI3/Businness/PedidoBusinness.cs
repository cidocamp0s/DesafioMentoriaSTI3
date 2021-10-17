using DesafioMentoriaSTI3.Data;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Data.Entidades;
using DesafioMentoriaSTI3.Model;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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

            Pedido p = new Pedido
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
                ClienteId = pedidoModel.Cliente.Id,
                EnderecoEntregaId = pedidoModel.EnderecoEntrega.Id,
                Itens = pedidoModel.Itens.Select(s => new ItensPedido
                {
                    Id = s.Id,
                    Quantidade = s.Quantidade,
                    ValorUnitario = s.ValorUnitario,
                    ProdutoId = s.ProdutoId


                }).ToList(),
                Pagamento = pedidoModel.Pagamento.Select(p => new Pagamento
                {
                    Id = p.Id,
                    Nome = p.Nome,
                    Codigo = p.Codigo,
                    Parcela = p.Parcela,
                    Valor = p.Valor

                }).ToList()
            };


            if (_context.Pedidos.Any(p => p.Id == pedidoModel.Id))
            {
                return;
            }
            else
            {

                _context.Pedidos.Add(p);
                _context.SaveChanges();
            }

        }

        public List<PedidoModel> ListarPedidos()
        {



            return _context.Pedidos.AsNoTracking().Select(p => new PedidoModel
            {
                Numero = p.Numero,
                DataCriacao = p.DataCriacao,
                Cliente = new ClienteModel
                {
                    Nome = p.Cliente.Nome

                },
                Status = p.Status,
                ValorTotal = p.ValorTotal

            }).ToList().OrderBy(x => x.Numero).ToList();




        }

        public List<PedidoModel> ListarPedidos(string nomeCliente)
        {



            return _context.Pedidos.AsNoTracking().Select(p => new PedidoModel
            {
                Numero = p.Numero,
                DataCriacao = p.DataCriacao,
                Cliente = new ClienteModel
                {
                    Nome = p.Cliente.Nome
                },
                Status = p.Status,
                ValorTotal = p.ValorTotal

            }).ToList().OrderBy(x => x.Numero).ToList().Where(s=> string.Equals(s.Cliente.Nome, nomeCliente, StringComparison.CurrentCultureIgnoreCase)).ToList();




        }

        public PedidoModel  PedidoDetalhado(double numeroPedidoSelecionado)
        {
            

            return _context.Pedidos.AsNoTracking().Select(p => new PedidoModel
            {
                Numero = p.Numero,
                DataCriacao = p.DataCriacao,
                DataAlteracao = p.DataAlteracao,
                Desconto = p.Desconto,
                Frete = p.Frete,
                SubTotal = p.SubTotal,

                EnderecoEntrega = new EnderecoEntregaModel
                {
                    Endereco = p.EnderecoEntrega.Endereco,
                    Bairro = p.EnderecoEntrega.Bairro,
                    Cep = p.EnderecoEntrega.Cep,
                    Cidade = p.EnderecoEntrega.Cidade,
                    Complemento = p.EnderecoEntrega.Complemento,
                    Estado = p.EnderecoEntrega.Estado,
                    Numero = p.EnderecoEntrega.Numero,
                    Referencia = p.EnderecoEntrega.Referencia,


                },

                Cliente = new ClienteModel
                {
                    Nome = p.Cliente.Nome,
                    Cpf = p.Cliente.Cpf,
                    DataNascimento = p.Cliente.DataNascimento,
                    Email = p.Cliente.Email,
                },

                Status = p.Status,
                ValorTotal = p.ValorTotal

            }).Where(x => x.Numero == numeroPedidoSelecionado ).First();



        }

    




    }
}
