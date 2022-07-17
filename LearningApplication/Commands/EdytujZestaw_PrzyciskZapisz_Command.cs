using LearningApplication.Helpers;
using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class EdytujZestaw_PrzyciskZapisz_Command : CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private EdytujZestaw_ViewModel _edytujZestaw_ViewModel;
        private string _stara_nazwa_zestawu;
        public EdytujZestaw_PrzyciskZapisz_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, EdytujZestaw_ViewModel edytujZestaw_ViewModel,string stara_nazwa_zestawu)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _edytujZestaw_ViewModel = edytujZestaw_ViewModel;
            _stara_nazwa_zestawu = stara_nazwa_zestawu;
        }        
        public override void Execute(object parameter)
        {
            List<Fiszka> nowa_lista_fiszek = Function.ZamieńNaListęFiszek(_edytujZestaw_ViewModel.EdytujZestaw_ListaFiszek_ViewModel.EdytujZestaw_ListaFiszek);           
            _lista_zestawów.Edytuj_Zestaw(_stara_nazwa_zestawu,_edytujZestaw_ViewModel.Edytuj_Zestaw_NazwaZestawu, nowa_lista_fiszek);           
            _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore,_lista_zestawów);
        }
    }
}
