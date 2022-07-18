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
    class ZakończenieZestawu_PowrótDoMenu_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        public ZakończenieZestawu_PowrótDoMenu_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new StronaGłówna_ViewModel(_navigationStore, _lista_zestawów);
        }
    }
}
