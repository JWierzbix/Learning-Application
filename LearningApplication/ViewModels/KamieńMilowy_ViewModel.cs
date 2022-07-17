using LearningApplication.Models;
using LearningApplication.Stores;
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
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        public KamieńMilowy_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
        }      
        public string Kamień_Milowy_Nazwa { get; }
        public ICommand Kamień_Milowy_Powrót_Przycisk { get; }
        public ICommand Kamień_Milowy_Kontynuuj { get; }

        //TRZEBA DODAĆ KONTROLKĘ DO PASKA POSTĘPU
    }
}
