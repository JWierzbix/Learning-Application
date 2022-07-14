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
    class Strona_Główna_WybierzZestaw_Command : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        public Strona_Główna_WybierzZestaw_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _lista_zestawów = lista_zestawów;
            _navigationStore = navigationStore;           
        }      
        
        public override void Execute(object parameter)
        {            
            _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore, _lista_zestawów);
        }


    }
}
