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
    class StwórzZestaw_ViewModel_AnulujCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;        
        public StwórzZestaw_ViewModel_AnulujCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;            
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new StronaGłówna_ViewModel(_navigationStore);
        }


    }
}
