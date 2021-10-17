using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Model;
using DesafioMentoriaSTI3.ViewModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace DesafioMentoriaSTI3.View.UserControls
{
    /// <summary>
    /// Interação lógica para Pedidos.xam
    /// </summary>
    public partial class Pedidos : UserControl
    {

        private UcPedidoViewModel UcPedidoVm = new UcPedidoViewModel();

        string jsonPedidos = new WebClient().DownloadString("https://desafiotecnicosti3.azurewebsites.net/pedido");

        public Pedidos()
        {

            InitializeComponent();

            DataContext = UcPedidoVm;

            VerificaJson();

          
          

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
                clientes.Add(item.Cliente);
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
                   UcPedidoVm.ListagemPedidos = new ObservableCollection<PedidoModel>(new PedidoBusinness().ListarPedidos());
        }
        public void ExibirPedidosCliente()
        {

            var cliente = UcPedidoVm.Nome;

            if (!string.IsNullOrEmpty(cliente))
            {
                UcPedidoVm.ListagemPedidos = new ObservableCollection<PedidoModel>(new PedidoBusinness().ListarPedidos(cliente));
            }

            else
            {
                ExibirPedidos();
                
            }

            UcPedidoVm.Nome = "";

        }
        public void ExibirPedidoDetalhado()
        {
            if (!LstPedidos.SelectedItem.Equals(null))
            {
                var pedidoSelecionado = LstPedidos.SelectedItem as PedidoModel;

                var numeroPedidoSelecionado = pedidoSelecionado.Numero;


                UcPedidoVm.PedidoDetalhado = new PedidoBusinness().PedidoDetalhado(numeroPedidoSelecionado);

            }



        }
        public void VerificaJson()
        {
            try
            {
              

                var jsonPedidos = new WebClient().DownloadString("https://desafiotecnicosti3.azurewebsites.net/pedido");


                SalvarClientes(ListagemClientes());

                SalvarProdutos(ListagemProdutos());

                SalvarEnderecosEntrega(ListagemEnderecos());

                SalvarPedidos(ListagemPedidos());


              
               

            }
            catch (System.Exception E)
            {

                MessageBox.Show(E.ToString(), "NÃO FOI POSSÍVEL A SINCRONIZAÇÃO, SERÃO EXIBIDOS OS DADOS SALVOS LOCALMENTE", MessageBoxButton.OK, MessageBoxImage.Warning);

            }

          
        }
    
        private void LstPedidos_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            ExibirPedidoDetalhado();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ExibirPedidos();
        }
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {



            if (sender is Button btn)
            {
                if (btn.Name == "BtnSincronizar")
                {
                    VerificaJson();

                    ExibirPedidos();

                    MessageBox.Show("Sucesso!!", "Sincronia Efetuada com sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                if (btn.Name == "BtnPesquisar")
                {
                    ExibirPedidosCliente();

                }



            }         

           
        }

    }










}

