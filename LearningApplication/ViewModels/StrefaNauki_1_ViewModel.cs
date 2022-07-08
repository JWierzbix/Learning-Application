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
        private Models.Fiszka _fiszka;
        public StrefaNauki_1_ViewModel(ref Models.Fiszka fiszka)
        {
            _fiszka = fiszka;
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
