using LearningApplication.Commands;
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
            KamieńMilowy_NazwaZestawu = zestaw.nazwa_zestawu;
            Kamień_Milowy_Kontynuuj = new KamieńMilowy_KontynuujPrzycisk_Command(navigationStore, lista_zestawów, zestaw);
            Kamień_Milowy_Powrót_Przycisk = new StrefaNauki_1_Powrót_Command(navigationStore, lista_zestawów);
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
        private string _kamieńMilowy_NazwaZeastawu;
        public string KamieńMilowy_NazwaZestawu
        {
            get => _kamieńMilowy_NazwaZeastawu;
            set
            {
                _kamieńMilowy_NazwaZeastawu = value;
                OnPropertyChanged(nameof(KamieńMilowy_NazwaZestawu));
            }
        }        
        public ICommand Kamień_Milowy_Powrót_Przycisk { get; }
        public ICommand Kamień_Milowy_Kontynuuj { get; }

        //TRZEBA DODAĆ KONTROLKĘ DO PASKA POSTĘPU
    }
}
