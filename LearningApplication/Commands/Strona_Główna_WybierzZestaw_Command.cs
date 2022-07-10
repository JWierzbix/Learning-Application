using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class Strona_Główna_WybierzZestaw_Command : CommandBase
    {
        private readonly NavigationStore navigationStore;
        public Strona_Główna_WybierzZestaw_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            this.navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
        }

        private readonly Lista_Zestawów _lista_zestawów;
        
        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new ViewModels.ListaZestawów_ViewModel(navigationStore,_lista_zestawów);
        }


    }
}
