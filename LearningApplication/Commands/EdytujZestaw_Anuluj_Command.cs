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
    class EdytujZestaw_Anuluj_Command : CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        public EdytujZestaw_Anuluj_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;            
        }
        public override void Execute(object parameter)
        {
            if (_navigationStore.Id == 12)
            {
                _navigationStore.CurrentViewModel = new StronaGłówna_ViewModel(_navigationStore, _lista_zestawów);
            }
            else if (_navigationStore.Id == 33)
            {
                _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore, _lista_zestawów);
            }
        }
    }
}
