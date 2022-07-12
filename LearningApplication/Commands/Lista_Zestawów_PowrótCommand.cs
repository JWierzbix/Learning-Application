using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class Lista_Zestawów_PowrótCommand: CommandBase
    {
        private readonly NavigationStore navigationStore;        
        public Lista_Zestawów_PowrótCommand(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;            
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new ViewModels.StronaGłówna_ViewModel(navigationStore);
        }
    }
}
