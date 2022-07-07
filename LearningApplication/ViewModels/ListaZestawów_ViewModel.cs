using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class ListaZestawów_ViewModel: ViewModelBase
    {
        public ICommand Lista_Zestawów_Powrót { get; }
        public ICommand Lista_Zestawów_UczSię { get; }
        public ICommand Lista_Zestawów_WyczyśćPostępy { get; }
        public ICommand Lista_Zestawów_Edytuj { get; }
        public ICommand Lista_Zestawów_Usuń { get; }
        private string _lista_zestawów_nazwa_zestawu;
        public string Lista_Zestawów_NazwaZestawu
        {
            get
            {
                return _lista_zestawów_nazwa_zestawu;
            }
            set
            {
                _lista_zestawów_nazwa_zestawu = value;
                OnPropertyChanged(nameof(Lista_Zestawów_NazwaZestawu));
            }
        }
    }
}
