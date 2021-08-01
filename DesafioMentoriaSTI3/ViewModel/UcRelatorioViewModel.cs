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


        private decimal _valorInicial;
        public decimal ValorInicial
        {
            get => _valorInicial;
            set
            {
                _valorInicial = value;
                OnPropertyChanged(nameof(ValorInicial));
            }
        }


        private decimal _valorFinal;
        public decimal ValorFinal
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

        private string _status;
        public string Status
        {
            get => _status;
            set 
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }





    }
}
