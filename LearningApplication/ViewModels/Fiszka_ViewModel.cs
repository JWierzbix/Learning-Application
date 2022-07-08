using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class Fiszka_ViewModel:ViewModelBase
    {
        private Models.Fiszka _fiszka;
        public ICommand Fiszka_ViewModel_Usuń { get; }
        public string Fiszka_ViewModel_PierwszaStrona => _fiszka.pierwsza_strona;
        public string Fiszka_ViewModel_DrugaStrona => _fiszka.druga_strona;
        public Fiszka_ViewModel(Models.Fiszka fiszka)
        {
            _fiszka = fiszka;
        }

    }
}
