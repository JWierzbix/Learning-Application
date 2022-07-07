using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class StronaGłówna_ViewModel: ViewModelBase
    {
        public ICommand Strona_Główna_StwórzZestaw { get; }
        public ICommand Strona_Główna_WybierzZestaw { get; }
        public ICommand Strona_Główna_UczSię { get; }
        public ICommand Strona_Główna_WyczyśćPostępy { get; }
        public ICommand Strona_Główna_Edytuj { get; }
        public ICommand Strona_Główna_Usuń { get; }
        private string _strona_główna_nazwa_zestawu;
        public string Strona_Główna_NazwaZestawu
        {
            get
            {
                return _strona_główna_nazwa_zestawu;
            }
            set
            {
                _strona_główna_nazwa_zestawu = value;
                OnPropertyChanged(nameof(Strona_Główna_NazwaZestawu));
            }
        }
    }
}
