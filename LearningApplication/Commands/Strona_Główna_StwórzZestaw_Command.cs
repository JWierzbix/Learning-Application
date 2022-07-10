using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class Strona_Główna_StwórzZestaw_Command : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Lista_Zestawów _lista_zestawów;
        public Strona_Główna_StwórzZestaw_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ViewModels.StwórzZestaw_ViewModel(_navigationStore, _lista_zestawów);
        }        
    }
}
