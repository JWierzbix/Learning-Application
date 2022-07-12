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
    class Fiszka_ViewModel_UsuńCommand: CommandBase
    {
        private NavigationStore _navigationStore;        
        private readonly Fiszka_ViewModel _fiszka_view_model;        
        public Fiszka_ViewModel_UsuńCommand(Fiszka_ViewModel fiszka_view_model, NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;            
            _fiszka_view_model = fiszka_view_model;            
        }

        public override void Execute(object parameter)
        {            
            _navigationStore.CurrentViewModel = new StwórzZestaw_ViewModel(_navigationStore);
        }
    }
}
