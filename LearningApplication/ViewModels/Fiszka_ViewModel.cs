using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    public class Fiszka_ViewModel : ViewModelBase
    {
        private Models.Fiszka _fiszka;        
        public ICommand Fiszka_ViewModel_Usuń { get; }
        public string Fiszka_ViewModel_PierwszaStrona => _fiszka.pierwsza_strona;
        public string Fiszka_ViewModel_DrugaStrona => _fiszka.druga_strona;
        public Fiszka_ViewModel(Models.Fiszka fiszka, StwórzZestaw_ListaFiszek_ViewModel stwórzZestaw_ListaFiszek_ViewModel)
        {
            _fiszka = fiszka;
            Fiszka_ViewModel_Usuń = new Commands.Fiszka_ViewModel_UsuńCommand(this, stwórzZestaw_ListaFiszek_ViewModel);
        }
        public Fiszka_ViewModel(Models.Fiszka fiszka, EdytujZestaw_ListaFiszek_ViewModel edytujZestaw_ListaFiszek_ViewModel)
        {
            _fiszka = fiszka;
            Fiszka_ViewModel_Usuń = new Commands.EdytujZestaw_Fiszka_Usuń_Command(this, edytujZestaw_ListaFiszek_ViewModel);
        }
    }
}
