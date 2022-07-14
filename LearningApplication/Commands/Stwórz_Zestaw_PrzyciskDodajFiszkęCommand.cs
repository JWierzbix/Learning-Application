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
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        public Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {            
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
        }

        public override void Execute(object parameter)
        {            
            _navigationStore.CurrentViewModel = new StwórzZestaw_ViewModel(_navigationStore, _lista_zestawów);   
        }
    }
}
