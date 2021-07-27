using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Data;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using DesafioMentoriaSTI3.ViewModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesafioMentoriaSTI3.View.UserControls
{
    /// <summary>
    /// Interação lógica para Pedidos.xam
    /// </summary>
    public partial class Pedidos : UserControl
    {

        private UcPedidoViewModel ucPedidoVm = new UcPedidoViewModel();

        string jsonPedidos = new WebClient().DownloadString("https://desafiotecnicosti3.azurewebsites.net/pedido");



        public Pedidos()
        {
            InitializeComponent();


         

            SalvarClientes(ListagemClientes());

            SalvarProdutos(ListagemProdutos());

            SalvarEnderecosEntrega(ListagemEnderecos());

            //SalvarItensPedidos(ListagemItens());

            //SalvarPagamentos(ListagemPagamentos());

            SalvarPedidos(ListagemPedidos());

         


            //ExibirPedidos();




        }

       


        public List<PedidoModel> ListagemPedidos()
        {            
            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(jsonPedidos);

            List<PedidoModel> pedido = new List<PedidoModel>();

            foreach (var item in pedidos)
            {
                pedido.Add(item);
            }


            return pedidos;

        }
        public List<ClienteModel> ListagemClientes()
        {

            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(jsonPedidos);

            List<ClienteModel> clientes = new List<ClienteModel>();

            foreach (var item in pedidos)
            {
                clientes.Add(item.cliente);
            }

            return clientes;
        }
        public List<EnderecoEntregaModel> ListagemEnderecos()
        {

            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(jsonPedidos);

            List<EnderecoEntregaModel> enderecoEntregas = new List<EnderecoEntregaModel>();


            foreach (var item in pedidos)
            {
                enderecoEntregas.Add(item.EnderecoEntrega);
            }

            return enderecoEntregas;
        }
        public List<PagamentoModel> ListagemPagamentos()
        {

            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(jsonPedidos);

            List<PagamentoModel> pagamentos = new List<PagamentoModel>();

            foreach (var item in pedidos)
            {
                foreach (var itens in item.Pagamento)
                {
                    pagamentos.Add(itens);
                }
               
            }

            return pagamentos;
        }
        public List<ItensPedidoModel> ListagemItens()
        {

            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(jsonPedidos);

            List<ItensPedidoModel> listaItens = new List<ItensPedidoModel>();

            foreach (var item in pedidos)
            {
                foreach (var itens in item.Itens)
                {
                    listaItens.Add(itens);
                }

            }

            return listaItens;
        }
        public List<ProdutoModel> ListagemProdutos()
        {

            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(jsonPedidos);

            List<ProdutoModel> listaProdutos = new List<ProdutoModel>();

            foreach (var item in pedidos)
            {
                foreach (var itens in item.Itens)
                {
                    listaProdutos.Add(new ProdutoModel
                    {
                        Id = itens.ProdutoId,
                        Nome = itens.Nome,
                        Valor = itens.ValorUnitario
                    });

                }

            }

            return listaProdutos;
        }



        public void SalvarPedidos(List<PedidoModel> ListaPedidos)
        {
            var pedido = new PedidoBusinness();

            foreach (var item in ListaPedidos)
            {



                pedido.AdicionarPedido(item);


            }

        }
        public void SalvarClientes(List<ClienteModel> ListaClientes)
        {
            var cliente = new ClienteBusinness();

            foreach (var item in ListaClientes)
            {
                cliente.AdicionarCliente(item);
            }

        }
        public void SalvarEnderecosEntrega(List<EnderecoEntregaModel> ListaEnderecosEntrega)
        {
            var enderecoEntrega = new EnderecoEntregaBusinness();

            foreach (var item in ListaEnderecosEntrega)
            {
                enderecoEntrega.AdicionarEndereco(item);
            }

        }
        public void SalvarPagamentos(List<PagamentoModel> ListaPagamentos)
        {
            var pagamentos = new PagamentoBusinness();

            foreach (var item in ListaPagamentos)
            {
                pagamentos.AdicionarPagamento(item);
            }

        }
        public void SalvarItensPedidos(List<ItensPedidoModel> ListaItensPedidos)
        {
            var Itenspedido = new ItensPedidoBusinness();

            foreach (var item in ListaItensPedidos)
            {
                Itenspedido.AdicionarItensPedido(item);
            }

        }
        public void SalvarProdutos(List<ProdutoModel> ListaProdutos)
        {
            var cliente = new ProdutoBusinnes();

            foreach (var item in ListaProdutos)
            {
                cliente.AdicionarProdutos(item);
            }

        }

        public void ExibirPedidos()
        {

            var listaPedidosClientes = new PedidoBusinness().ListarPedidos();


            foreach (var item in listaPedidosClientes)
            {
                ucPedidoVm.ListaPedidos.Add(new PedidoModel
                {
                    Numero = item.Numero,
                    DataCriacao = item.DataCriacao,
                    Id=item.Id
                   
                    
                    


                });
            }




        }









    }
}
