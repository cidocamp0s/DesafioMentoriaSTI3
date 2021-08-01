using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using DesafioMentoriaSTI3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public UcRelatorio()
        {
            InitializeComponent();

            DataContext = UcRelatorioVm;

        }

        private void FiltrarPedidos(object sender)
        {
            var listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioGeral();

            if (sender is Button btn)
            {
               
                    var filtros = (sender as Button).Tag as UcRelatorioViewModel;

                    var nome = filtros.Nome;

                    var numeroInicial = filtros.NumeroInicial;
                    var numeroFInal = filtros.NumeroFinal;

                    var valorInicial = filtros.ValorInicial;
                    var valorFinal = filtros.ValorFinal;

                    var dataInicial = filtros.DataInicial;
                    var dataFinal = filtros.DataFinal;

                    var status = filtros.Status;

                    if (!string.IsNullOrEmpty(nome))
                    {
                        listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorCliente(nome, listaRelatorio);
                    }

                    if (numeroInicial > 0 && numeroFInal >= numeroInicial)
                    {
                        listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorNumero(numeroInicial, numeroFInal, listaRelatorio);
                    }

                    if (valorInicial > 0 && valorFinal >= valorInicial)
                    {
                        listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorValor(valorInicial, valorFinal, listaRelatorio);
                    }

                    if (dataInicial != null && dataFinal >= dataInicial)
                    {
                        listaRelatorio = new RelatorioBusinness().ListaPedidosRelatorioPorData(dataInicial, dataFinal, listaRelatorio);
                    }


                    ListarPedidosFiltrados(listaRelatorio);


                
            }
        }
        private void ListarPedidosFiltrados(List<RelatorioModel> listaFiltrada)
        {
            UcRelatorioVm.RelatorioListaPedidos = new ObservableCollection<RelatorioModel>(new RelatorioBusinness().ListaFiltrada(listaFiltrada));
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

    }

}
