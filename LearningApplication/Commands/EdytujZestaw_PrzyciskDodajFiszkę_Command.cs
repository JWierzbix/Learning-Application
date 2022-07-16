using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class EdytujZestaw_PrzyciskDodajFiszkę_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        private EdytujZestaw_ListaFiszek_ViewModel _edytujZestaw_ListaFiszek_ViewModel;
        public EdytujZestaw_PrzyciskDodajFiszkę_Command(NavigationStore navigationStore, EdytujZestaw_ListaFiszek_ViewModel edytujZestaw_ListaFiszek_ViewModel)
        {
            _navigationStore = navigationStore;
            _edytujZestaw_ListaFiszek_ViewModel = edytujZestaw_ListaFiszek_ViewModel;
        }
        public override void Execute(object parameter)
        {
            string pierwsza_strona = _edytujZestaw_ListaFiszek_ViewModel.Edytuj_Zestaw_PierwszaStronaFiszki;
            string druga_strona = _edytujZestaw_ListaFiszek_ViewModel.Edytuj_Zestaw_DrugaStronaFiszki;
            Fiszka f = new Fiszka(pierwsza_strona, druga_strona);
            Fiszka_ViewModel ff = new Fiszka_ViewModel(f, _edytujZestaw_ListaFiszek_ViewModel);
            ((ObservableCollection<Fiszka_ViewModel>)_edytujZestaw_ListaFiszek_ViewModel.EdytujZestaw_ListaFiszek).Add(ff);
            _edytujZestaw_ListaFiszek_ViewModel.Edytuj_Zestaw_PierwszaStronaFiszki = "";
            _edytujZestaw_ListaFiszek_ViewModel.Edytuj_Zestaw_DrugaStronaFiszki = "";
        }
    }
}
