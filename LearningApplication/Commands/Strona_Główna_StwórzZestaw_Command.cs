using LearningApplication.Models;
using LearningApplication.Stores;
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
        public Strona_Główna_StwórzZestaw_Command(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;            
        }

        public override void Execute(object parameter)
        {            
            _navigationStore.CurrentViewModel = new ViewModels.StwórzZestaw_ViewModel(_navigationStore);
        }        
    }
}
