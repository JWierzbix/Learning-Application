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
    class Stwórz_Zestaw_PrzyciskStwórzCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly StwórzZestaw_ViewModel _stwórz_Zestaw_view_model;
               
        public Stwórz_Zestaw_PrzyciskStwórzCommand(StwórzZestaw_ViewModel stwórz_zestaw_view_model, NavigationStore navigationStore)
        {
            _stwórz_Zestaw_view_model = stwórz_zestaw_view_model;
            _navigationStore = navigationStore;            
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore);
        }
        
    }
}
