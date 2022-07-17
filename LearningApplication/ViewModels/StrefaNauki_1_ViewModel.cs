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
    class StrefaNauki_1_ViewModel : ViewModelBase
    {        
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        private string[] _dane;
        public StrefaNauki_1_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw, string[] dane)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
            _dane = dane;
            //uzupełnianie danych
            Strefa_Nauki_1_Słowo = zestaw.Pojęcie+" :";
            Strefa_Nauki_1_Odpowiedź_A_Text = "A. " + dane[0];
            Strefa_Nauki_1_Odpowiedź_B_Text = "B. " + dane[1];
            Strefa_Nauki_1_Odpowiedź_C_Text = "C. " + dane[2];
            Strefa_Nauki_1_Odpowiedź_D_Text = "D. " + dane[3];
            Strefa_Nauki_1_NazwaZestawu = zestaw.nazwa_zestawu;
        }      

        private string _strefa_nauki_1_słowo;
        public string Strefa_Nauki_1_Słowo
        {
            get
            {
                return _strefa_nauki_1_słowo;
            }
            set
            {
                _strefa_nauki_1_słowo = value;
                OnPropertyChanged(nameof(Strefa_Nauki_1_Słowo));
            }
        }
        // Odpowiedź A
        private string _strefa_nauki_1_odpowiedź_A_Text;
        public string Strefa_Nauki_1_Odpowiedź_A_Text
        {
            get
            {
                return _strefa_nauki_1_odpowiedź_A_Text;
            }
            set
            {
                _strefa_nauki_1_odpowiedź_A_Text = value;
                OnPropertyChanged(nameof(Strefa_Nauki_1_Odpowiedź_A_Text));
            }
        }
        public ICommand Strefa_Nauki_1_Odpowiedź_A_Przycisk { get; }
        // Odpowiedź B
        private string _strefa_nauki_1_odpowiedź_B_Text;
        public string Strefa_Nauki_1_Odpowiedź_B_Text
        {
            get
            {
                return _strefa_nauki_1_odpowiedź_B_Text;
            }
            set
            {
                _strefa_nauki_1_odpowiedź_B_Text = value;
                OnPropertyChanged(nameof(Strefa_Nauki_1_Odpowiedź_B_Text));
            }
        }
        public ICommand Strefa_Nauki_1_Odpowiedź_B_Przycisk { get; }
        // Odpowiedź C
        private string _strefa_nauki_1_odpowiedź_C_Text;
        public string Strefa_Nauki_1_Odpowiedź_C_Text
        {
            get
            {
                return _strefa_nauki_1_odpowiedź_C_Text;
            }
            set
            {
                _strefa_nauki_1_odpowiedź_C_Text = value;
                OnPropertyChanged(nameof(Strefa_Nauki_1_Odpowiedź_C_Text));
            }
        }
        public ICommand Strefa_Nauki_1_Odpowiedź_C_Przycisk { get; }
        // Odpowiedź D
        private string _strefa_nauki_1_odpowiedź_D_Text;
        public string Strefa_Nauki_1_Odpowiedź_D_Text
        {
            get
            {
                return _strefa_nauki_1_odpowiedź_D_Text;
            }
            set
            {
                _strefa_nauki_1_odpowiedź_D_Text = value;
                OnPropertyChanged(nameof(Strefa_Nauki_1_Odpowiedź_D_Text));
            }
        }
        public ICommand Strefa_Nauki_1_Odpowiedź_D_Przycisk { get; }
        // Poprawność Odpowiedzi        
        public string Strefa_Nauki_1_PoprawnośćOdpowiedzi { get; }        
        //Inne Informacje        
        public string Strefa_Nauki_1_NazwaZestawu { get; }
        
        public ICommand Strefa_Nauki_1_Powrót { get; }

        // TRZEBA JESZCZE DODAĆ PASEK POSTĘPU ALE MUSZĘ SIĘ DOWIEDZIEĆ NAJPIERW JAKI ONA MA MIEĆ TYP
    }
}
