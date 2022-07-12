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
    class Stwórz_Zestaw_PrzyciskDodajFiszkęCommand : CommandBase
    {
        private StwórzZestaw_ViewModel _stwórz_zestaw_view_model;
        private NavigationStore _navigationStore;       
        
        public Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(StwórzZestaw_ViewModel stwórz_zestaw_view_model, NavigationStore navigationStore)
        {
            _stwórz_zestaw_view_model = stwórz_zestaw_view_model;
            _navigationStore = navigationStore;            
        }

        public override void Execute(object parameter)
        {            
            _navigationStore.CurrentViewModel = new StwórzZestaw_ViewModel(_navigationStore);   
        }
    }
}
