using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DesafioMentoriaSTI3.ViewModel
{
    public class UcPedidoViewModel : PropertyChange
    {

        private ObservableCollection<PedidoModel> _listaPedidos;
        public ObservableCollection<PedidoModel> ListaPedidos
        {
            get => _listaPedidos;
            set
            {
                _listaPedidos = value;
                OnPropertyChanged(nameof(ListaPedidos));
            }
        }


    }
}
