using DesafioMentoriaSTI3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DesafioMentoriaSTI3.ViewModel
{
    class UcRelatorioViewModel : PropertyChange
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


        private double _numeroInicial;
        public double NumeroInicial
        {
            get => _numeroInicial;
            set
            {
                _numeroInicial = value;
                OnPropertyChanged(nameof(NumeroFinal));
            }
        }


        private double _numeroFinal;
        public double NumeroFinal
        {
            get => _numeroFinal;
            set
            {
                _numeroFinal= value;
                OnPropertyChanged(nameof(NumeroFinal));
            }
        }


        private double _valorInicial;
        public double ValorInicial
        {
            get => _valorInicial;
            set
            {
                _valorInicial = value;
                OnPropertyChanged(nameof(ValorInicial));
            }
        }


        private double _valorFinal;
        public double ValorFinal
        {
            get => _valorFinal;
            set
            {
                _valorFinal = value;
                OnPropertyChanged(nameof(ValorFinal));
            }
        }


        private DateTime _dataFinal;
        public DateTime DataFinal
        {
            get => _dataFinal;
            set
            {
                _dataFinal = value;
                OnPropertyChanged(nameof(DataFinal));
            }
        }


        private DateTime _dataInicial;
        public DateTime DataInicial
        {
            get => _dataInicial;
            set
            {
                _dataInicial = value;
                OnPropertyChanged(nameof(DataInicial));
            }
        }






    }
}
