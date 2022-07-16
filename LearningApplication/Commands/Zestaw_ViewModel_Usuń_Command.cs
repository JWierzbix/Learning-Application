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
    class Zestaw_ViewModel_Usuń_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        public Zestaw_ViewModel_Usuń_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;            
        }
        public override void Execute(object parameter)
        {
            _lista_zestawów.UsuńZestaw(_zestaw.nazwa_zestawu);
            if (_navigationStore.Id == 12)
            {
                _navigationStore.CurrentViewModel = new StronaGłówna_ViewModel(_navigationStore, _lista_zestawów);
            }
            else if(_navigationStore.Id == 33)
            {
                _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore, _lista_zestawów);
            }
        }
    }
}
