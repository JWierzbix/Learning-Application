using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.Commands;
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
            Zakończenie_Zestawu_NazwaZestawu = zestaw.nazwa_zestawu;
            Zakończenie_Zestawu_PowrótDoListyZestawów = new StrefaNauki_1_Powrót_Command(navigationStore,lista_zestawów);
            Zakończenie_Zestawu_PowrótDoMenu = new ZakończenieZestawu_PowrótDoMenu_Command(navigationStore, lista_zestawów);
            Zakończenie_Zestawu_UczSięOdNowa = new ZakończenieZestaw_UczSięOdNowa_Command(navigationStore,lista_zestawów,zestaw);
            ObecnyProgres = lista_zestawów.lista_zestawów[zestaw.nazwa_zestawu].Poziom_Ukończenia();
        }
        private double _obecnyProgres;
        public double ObecnyProgres
        {
            get { return _obecnyProgres; }
            set
            {
                _obecnyProgres = value;
                OnPropertyChanged(nameof(ObecnyProgres));
            }
        }
        private string zakończenie_Zestawu_NazwaZestawu;
        public string Zakończenie_Zestawu_NazwaZestawu
        {
            get => zakończenie_Zestawu_NazwaZestawu;
            set
            {
                zakończenie_Zestawu_NazwaZestawu = value;
                OnPropertyChanged(nameof(Zakończenie_Zestawu_NazwaZestawu));
            }
        }
        public ICommand Zakończenie_Zestawu_PowrótDoListyZestawów { get; }
        public ICommand Zakończenie_Zestawu_PowrótDoMenu { get; }
        public ICommand Zakończenie_Zestawu_UczSięOdNowa { get; }
        
        //TRZEBA DODAĆ PASEK POSTĘPU
    }
}
