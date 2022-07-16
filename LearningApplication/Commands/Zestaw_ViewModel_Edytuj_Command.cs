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
    class Zestaw_ViewModel_Edytuj_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw_ViewModel _zestaw_ViewModel;
        public Zestaw_ViewModel_Edytuj_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw_ViewModel zestaw_ViewModel)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw_ViewModel = zestaw_ViewModel;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new EdytujZestaw_ViewModel(_navigationStore,_lista_zestawów,_zestaw_ViewModel);
        }
    }
}
