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
        public ObservableCollection<PedidoModel> ListagemPedidos
        {
            get => _listaPedidos;
            set
            {
                _listaPedidos = value;
                OnPropertyChanged(nameof(ListagemPedidos));
            }
        }

        private PedidoModel _pedidoDetalhado;
        public PedidoModel PedidoDetalhado
        {
            get => _pedidoDetalhado;
            set
            {
                _pedidoDetalhado = value;
                OnPropertyChanged(nameof(PedidoDetalhado));
            }
        }


        private string _nome;
        public string Nome
        {
            get => _nome;
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }



    }
}
