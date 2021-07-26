using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesafioMentoriaSTI3.ViewModel
{
    class UcRelatorioViewModel:PropertyChange
    {

        private ObservableCollection<RelatorioModel> _relatorioListaPedidos;
        public ObservableCollection<RelatorioModel> RelatorioListaPedidos
        {
            get => _relatorioListaPedidos;
            set
            {
                _relatorioListaPedidos = value;
                OnPropertyChanged(nameof(RelatorioListaPedidos));
            }
        }

               

    }
}
