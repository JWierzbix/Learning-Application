using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class Zestaw_ViewModel_UczSię_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        public Zestaw_ViewModel_UczSię_Command(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {

        }
    }
}
