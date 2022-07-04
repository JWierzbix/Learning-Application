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
        }
        private string _strefa_nauki_2_poprawność_odpowiedzi;
        public string Strefa_Nauki_2_PoprawnośćOdpowiedzi
        {
            get
            {
                return _strefa_nauki_2_poprawność_odpowiedzi;
            }
        }
        public ICommand Strefa_Nauki_2_Powrót { get; }
        public ICommand Strefa_Nauki_2_Zatwierdź { get; }

        //TRZEBA JESZCZE DODAĆ POSTĘP W NAUCE ALE JAK BĘDĘ WIEDZIAŁ JAKI JEST TYP 
    }
}
