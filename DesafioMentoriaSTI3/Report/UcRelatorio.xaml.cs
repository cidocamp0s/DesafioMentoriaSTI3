using DesafioMentoriaSTI3.Data.Context;
using DesafioMentoriaSTI3.Model;
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
    /// Interação lógica para UcRelatorio.xam
    /// </summary>
    public partial class UcRelatorio : UserControl
    {
        private UcRelatorioViewModel UcRelatorioVm = new UcRelatorioViewModel();
        public UcRelatorio()
        {
            InitializeComponent();

            DataContext = UcRelatorioVm;

            //teste();

            CcRelatorio.Content = new UcVisualizacaoPedidos();

        }

        public void teste()
        {
            

            UcRelatorioVm.RelatorioListaPedidos = new System.Collections.ObjectModel.ObservableCollection<RelatorioModel>()
            {


                new RelatorioModel
                {
                    Cliente = "cido",
                    Numero = 31,
                    Status = "Aprovado 1"
                },
                 new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                },
                    new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                },
                    new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                },
                    new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                },
                    new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                },
                    new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                },
                    new RelatorioModel
                {
                    Cliente = "jaque",
                    Numero = 28,
                    Status = "Aprovado 2"
                },
                  new RelatorioModel
                {
                    Cliente = "matheus",
                    Numero = 17,
                    Status = "Aprovado 3"
                }





            };
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("etste");

        }
    }
}
