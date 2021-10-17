using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using DesafioMentoriaSTI3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesafioMentoriaSTI3.Report
{
    /// <summary>
    /// Interação lógica para UcRelatorio.xam
    /// </summary>
    public partial class UcRelatorio : UserControl
    {

        private UcRelatorioViewModel UcRelatorioVm = new UcRelatorioViewModel();

        List<ClienteModel> ClientesChecados = new List<ClienteModel>();
        List<RelatorioModel> StatusChecados = new List<RelatorioModel>();

        public UcRelatorio()
        {
            ListarClientes();
            ListarStatus();

            InitializeComponent();

            DataContext = UcRelatorioVm;

        }

        private void FiltrarPedidos(object sender)
        {
            var listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioGeral();

            if (sender is Button btn)
            {

                var filtros = (sender as Button).Tag as UcRelatorioViewModel;


                var numeroInicial = filtros.NumeroInicial;
                var numeroFInal = filtros.NumeroFinal;

                var valorInicial = filtros.ValorInicial;
                var valorFinal = filtros.ValorFinal;

                var dataInicial = filtros.DataInicial;
                var dataFinal = filtros.DataFinal;

                var status = filtros.StatusPedidos;


                if (numeroInicial > 0 && numeroFInal >= numeroInicial)
                {
                    listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorNumero(numeroInicial, numeroFInal, listaRelatorio);
                }

                if (valorInicial > 0 && valorFinal >= valorInicial)
                {
                    listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorValor(valorInicial, valorFinal, listaRelatorio);
                }

                if (dataInicial > Convert.ToDateTime("01-01-1000") && dataFinal >= dataInicial)
                {
                    listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorData(dataInicial, dataFinal, listaRelatorio);
                }

                if (ClientesChecados.Count > 0)
                {
                    listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorCliente(listaRelatorio, ClientesChecados);
                }

                if (StatusChecados.Count > 0)
                {
                    listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorStatus(StatusChecados, listaRelatorio);
                }


                ListarPedidosFiltrados(listaRelatorio);



            }
        }
        private void ListarPedidosFiltrados(List<RelatorioModel> listaFiltrada)
        {
            UcRelatorioVm.RelatorioListaPedidos = new ObservableCollection<RelatorioModel>(new RelatorioBusinness().ListaFiltrada(listaFiltrada));
        }
        private void ListarClientes()
        {
            UcRelatorioVm.RelatorioListaClientes = new ObservableCollection<RelatorioModel>(new RelatorioBusinness().Clientes());
        }
        private void ListarStatus()
        {
            UcRelatorioVm.StatusPedidos = new ObservableCollection<RelatorioModel>(new RelatorioBusinness().StatusExistentes());
        }
        private List<ClienteModel> ClientesSelecionados(RoutedEventArgs e)
        {
            var checado = (e.Source as CheckBox).IsChecked;

            if ((bool)checado == true)
            {

                ClientesChecados.Add(new ClienteModel { Nome = (e.Source as CheckBox).Content.ToString() });
            }


            else
            {

                ClientesChecados.RemoveAll(x => x.Nome == (e.Source as CheckBox).Content.ToString());
            }




            return ClientesChecados;


        }

        private List<RelatorioModel> StatusSelecionados(RoutedEventArgs e)
        {
            var checado = (e.Source as CheckBox).IsChecked;


            if ((bool)checado == true)
            {

                StatusChecados.Add(new RelatorioModel { Status = (e.Source as CheckBox).Content.ToString() });
            }


            else
            {

                StatusChecados.RemoveAll(x => x.Status == (e.Source as CheckBox).Content.ToString());
            }



            return StatusChecados;


        }
        private void ValidarValorInput(object sender, TextCompositionEventArgs e)
        {
            Regex valor = new Regex("[^0-9]+");
            e.Handled = valor.IsMatch(e.Text);
        }
        private void BtnRelatorio_Click(object sender, RoutedEventArgs e)
        {

            FiltrarPedidos(sender);

        }
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if ((e.Source as CheckBox).Name == "status")
            {
                StatusSelecionados(e);
            }
            else
            {
                ClientesSelecionados(e);
            }


        }
    }

}
