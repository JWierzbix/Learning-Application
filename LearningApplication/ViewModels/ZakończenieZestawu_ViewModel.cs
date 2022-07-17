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
    class ZakończenieZestawu_ViewModel:ViewModelBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        public ZakończenieZestawu_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
        }
        public ICommand Zakończenie_Zestawu_PowrótDoListyZestawów { get; }
        public ICommand Zakończenie_Zestawu_PowrótDoMenu { get; }
        public ICommand Zakończenie_Zestawu_UczSięOdNowa { get; }
        
        //TRZEBA DODAĆ PASEK POSTĘPU
    }
}
