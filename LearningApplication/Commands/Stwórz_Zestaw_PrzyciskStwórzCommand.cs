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
    class Stwórz_Zestaw_PrzyciskStwórzCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly StwórzZestaw_ViewModel _stwórz_Zestaw_view_model;
        private Lista_Zestawów _lista_zestawów;        
        public Stwórz_Zestaw_PrzyciskStwórzCommand(StwórzZestaw_ViewModel stwórz_zestaw_view_model, NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _stwórz_Zestaw_view_model = stwórz_zestaw_view_model;
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
        }
        public override void Execute(object parameter)
        {
            List<Fiszka> nowa_lista_fiszek = Zestaw.Zamień_Na_Listę_Fiszek(_stwórz_Zestaw_view_model.StwórzZestaw_ListaFiszek);            
            if (_lista_zestawów.Utwórz_Zestaw(_stwórz_Zestaw_view_model.Stwórz_Zestaw_NazwaZestawu, nowa_lista_fiszek))
            {
                _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore, _lista_zestawów);
            }
            else
            {
                //wyskakuje błąd
            }
        }
        
    }
}
