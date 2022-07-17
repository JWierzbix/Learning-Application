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
    class StrefaNauki_2_ViewModel: ViewModelBase
    {        
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;    
        public StrefaNauki_2_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
            Strefa_Nauki_2_NazwaZestawu = _zestaw.nazwa_zestawu;
            Strefa_Nauki_2_Słowo = _zestaw.Pojęcie;
            Strefa_Nauki_2_Zatwierdź = new StrefaNauki_2_Zatwierdź_Command(navigationStore, lista_zestawów, zestaw, this);
            Strefa_Nauki_2_Powrót = new StrefaNauki_1_Powrót_Command(navigationStore, lista_zestawów);
        }
        private string _strefa_nauki_2_słowo;
        public string Strefa_Nauki_2_Słowo
        {
            get
            {
                return _strefa_nauki_2_słowo;
            }
            set
            {
                _strefa_nauki_2_słowo = value;
                OnPropertyChanged(nameof(Strefa_Nauki_2_Słowo));
            }
        }
        private string _strefa_nauki_2_odpowiedź;
        public string Strefa_Nauki_2_Odpowiedź
        {
            get
            {
                return _strefa_nauki_2_odpowiedź;
            }
            set
            {
                _strefa_nauki_2_odpowiedź = value;
                OnPropertyChanged(nameof(Strefa_Nauki_2_Odpowiedź));
            }
        }
        private string _strefa_nauki_2_nazwa_zestawu;
        public string Strefa_Nauki_2_NazwaZestawu
        {
            get
            {
                return _strefa_nauki_2_nazwa_zestawu;
            }
            set
            {
                _strefa_nauki_2_nazwa_zestawu = value;
                OnPropertyChanged(nameof(Strefa_Nauki_2_NazwaZestawu));
            }
        }
        private string _strefa_nauki_2_poprawność_odpowiedzi;
        public string Strefa_Nauki_2_PoprawnośćOdpowiedzi
        {
            get
            {
                return _strefa_nauki_2_poprawność_odpowiedzi;
            }
            set
            {
                _strefa_nauki_2_poprawność_odpowiedzi = value;
                OnPropertyChanged(nameof(Strefa_Nauki_2_PoprawnośćOdpowiedzi));
            }
        }
        public ICommand Strefa_Nauki_2_Powrót { get; }
        public ICommand Strefa_Nauki_2_Zatwierdź { get; }

        //TRZEBA JESZCZE DODAĆ POSTĘP W NAUCE ALE JAK BĘDĘ WIEDZIAŁ JAKI JEST TYP 
    }
}
