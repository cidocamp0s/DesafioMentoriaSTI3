using DesafioMentoriaSTI3.Businness;
using DesafioMentoriaSTI3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public Pedidos()
        {
            InitializeComponent();
            DPedidos();
        }


        public void DPedidos()
        {

            var json = new WebClient().DownloadString("https://desafiotecnicosti3.azurewebsites.net/pedido");

            var pedidos = JsonConvert.DeserializeObject<List<PedidoModel>>(json);

            var pedido = new PedidoBusinness();

            foreach (var item in pedidos)
            {
                
               pedido.AdicionarPedido(item);
                

            };

        }


    }
}
