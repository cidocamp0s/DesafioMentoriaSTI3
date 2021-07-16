using DesafioMentoriaSTI3.View.UserControls;
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
using System.Windows.Shapes;

namespace DesafioMentoriaSTI3.View
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            conteudo.Content = new Pedidos();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void BtnBarraTitulo_Click(object sender, RoutedEventArgs e)
        {
            AcaoNaJanela(sender);
        }

        private void AcaoNaJanela(object sender)
        {
            if (sender is Button btn)
            {

                if (btn.Name == "BtnMaximizar")
                {
                    MaximizarAplicacao();
                }

                else if (btn.Name == "BtnMinimizar")
                {
                    MinimizarAplicacao();
                }

                else
                {
                    FecharAplicacao();
                }
            }
        }

        private void FecharAplicacao()
        {
            if (MessageBox.Show("Fechar", "Deseja Fechar a aplicação", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
            {
                Close();
            }

        }

        private void MaximizarAplicacao()
        {
            //    Height = SystemParameters.MaximizedPrimaryScreenHeight;
            //    Width = SystemParameters.MaximizedPrimaryScreenWidth;
            //    this.WindowState = WindowState.Normal;
            if (WindowState != WindowState.Maximized)
            {
                WindowState = System.Windows.WindowState.Maximized;

            }
            else
            {
                WindowState = WindowState.Normal;
            }






        }

        private void MinimizarAplicacao()
        {
            WindowState = WindowState.Minimized;
        }
    }
}
