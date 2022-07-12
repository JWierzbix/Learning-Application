using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class KamieńMilowy_ViewModel: ViewModelBase
    {        
        public string Kamień_Milowy_Nazwa { get; }
        public ICommand Kamień_Milowy_Powrót_Przycisk { get; }
        public ICommand Kamień_Milowy_Kontynuuj { get; }

        //TRZEBA DODAĆ KONTROLKĘ DO PASKA POSTĘPU
    }
}
