using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
using DesafioMentoriaSTI3.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            CarregarPedidos();
        }



        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("etste");

        }


        private void BtnVisualizarRelatorio_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "BtnVisualizarRelatorio")
                {


                }
            }
        }

        private void BtnRelatorio_Click(object sender, RoutedEventArgs e)
        {
            //UcRelatorioVm.RelatorioListaPedidos = new ObservableCollection<RelatorioModel>(new RelatorioBusinness().ListaFiltradaPedidosRelatorio);
        }


        private void CarregarPedidos()
        {
            UcRelatorioVm.RelatorioListaPedidos = new ObservableCollection<RelatorioModel>(new RelatorioBusinness().ListaPedidosRelatorio());
        }
    }

}
