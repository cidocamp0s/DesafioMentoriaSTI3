using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioMentoriaSTI3.ViewModel
{
    class UcMenuViewModel : PropertyChange
    {
        private string _descricaoMenu;
        public string DescricaoMenu
        {
            get => _descricaoMenu;

            set
            {
                _descricaoMenu = value;
                OnPropertyChanged(nameof(DescricaoMenu));
            }
        }


        private string _versao;
        public string Versao
        {
            get => _versao;

            set
            {
                _versao = value;
                OnPropertyChanged(nameof(Versao));
            }
        }
    }
}
