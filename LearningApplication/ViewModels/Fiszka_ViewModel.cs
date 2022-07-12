using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    internal class Fiszka_ViewModel : ViewModelBase
    {
        private Models.Fiszka _fiszka;
        private NavigationStore _navigationStore;
        public ICommand Fiszka_ViewModel_Usuń { get; }
        public string Fiszka_ViewModel_PierwszaStrona => _fiszka.pierwsza_strona;
        public string Fiszka_ViewModel_DrugaStrona => _fiszka.druga_strona;
        public Fiszka_ViewModel(Models.Fiszka fiszka)
        {
            _fiszka = fiszka;
            Fiszka_ViewModel_Usuń = new Commands.Fiszka_ViewModel_UsuńCommand(this, _navigationStore);
        }

    }
}
