using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.ViewModel;
using System;
using System.Collections.Generic;
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
    /// Interação lógica para UcVisualizacaoPedidos.xam
    /// </summary>
    public partial class UcVisualizacaoPedidos : UserControl
    {

        private UcRelatorioViewModel UcRelatorioVm = new UcRelatorioViewModel();
        public UcVisualizacaoPedidos()
        {
            InitializeComponent();

            DataContext = UcRelatorioVm;

            CarregarPedidosRelatorio();
        }

        public void CarregarPedidosRelatorio()
        {
            

            RelatorioBusinness relatorio = new RelatorioBusinness();

            foreach (var item in relatorio.ListaPedidosRelatorio())
            {

                UcRelatorioVm.RelatorioListaPedidos.Add(item);
            }






        }
    }
}
