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
        private readonly StwórzZestaw_ViewModel _stwórzZestaw_ViewModel;//potrzebne są dane
        private Lista_Zestawów _lista_zestawów;
               
        public Stwórz_Zestaw_PrzyciskStwórzCommand(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, StwórzZestaw_ViewModel stwórzZestaw_ViewModel)
        {
            _lista_zestawów = lista_zestawów;
            _stwórzZestaw_ViewModel = stwórzZestaw_ViewModel;            
            _navigationStore = navigationStore;            
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore, _lista_zestawów);
        }
        
    }
}
