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
    class Strona_Główna_StwórzZestaw_Command : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private StronaGłówna_OstatnioUżywaneZestawy_ViewModel _stronaGłówna_OstatnioUżywaneZestawy_ViewModel;
        public Strona_Główna_StwórzZestaw_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, StronaGłówna_OstatnioUżywaneZestawy_ViewModel stronaGłówna_OstatnioUżywaneZestawy_ViewModel)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _stronaGłówna_OstatnioUżywaneZestawy_ViewModel = stronaGłówna_OstatnioUżywaneZestawy_ViewModel;
        }

        public override void Execute(object parameter)
        {             
            _navigationStore.CurrentViewModel = new ViewModels.StwórzZestaw_ViewModel(_navigationStore,_lista_zestawów);
        }        
    }
}
