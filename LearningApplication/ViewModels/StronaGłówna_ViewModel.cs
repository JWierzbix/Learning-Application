using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class StronaGłówna_ViewModel: ViewModelBase
    {
        private readonly Lista_Zestawów _lista_zestawów;
        public StronaGłówna_OstatnioUżywaneZestawy_ViewModel StronaGłówna_OstatnioUżywaneZestawy { get; }          
        public ICommand Strona_Główna_StwórzZestaw { get; }
        public ICommand Strona_Główna_WybierzZestaw { get; }    
        
        public StronaGłówna_ViewModel(NavigationStore navigationStore,Lista_Zestawów lista_zestawów)       
        {
            navigationStore.Id = 12;
            _lista_zestawów = lista_zestawów;
            StronaGłówna_OstatnioUżywaneZestawy = new StronaGłówna_OstatnioUżywaneZestawy_ViewModel(navigationStore, _lista_zestawów);
            Strona_Główna_StwórzZestaw = new Commands.Strona_Główna_StwórzZestaw_Command(navigationStore, lista_zestawów, StronaGłówna_OstatnioUżywaneZestawy);
            Strona_Główna_WybierzZestaw = new Commands.Strona_Główna_WybierzZestaw_Command(navigationStore, lista_zestawów);            
        }
    }
}
