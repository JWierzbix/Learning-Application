using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class StwórzZestaw_ViewModel: ViewModelBase
    {
        private string _stwórz_zestaw_nazwa_zestawu;
        public string Stwórz_Zestaw_NazwaZestawu
        {
            get
            {
                return _stwórz_zestaw_nazwa_zestawu;
            }
            set
            {
                _stwórz_zestaw_nazwa_zestawu = value;
                OnPropertyChanged(nameof(Stwórz_Zestaw_NazwaZestawu));
            }
        }
        private string _stwórz_zestaw_pierwsza_strona_fiszki;
        public string Stwórz_Zestaw_PierwszaStronaFiszki
        {
            get
            {
                return _stwórz_zestaw_pierwsza_strona_fiszki;
            }
            set
            {
                _stwórz_zestaw_pierwsza_strona_fiszki = value;
                OnPropertyChanged(nameof(Stwórz_Zestaw_PierwszaStronaFiszki));
            }
        }
        
        private string _stwórz_zestaw_druga_strona_fiszki;
        public string Stwórz_Zestaw_DrugaStronaFiszki
        {
            get
            {
                return _stwórz_zestaw_druga_strona_fiszki;
            }
            set
            {
                _stwórz_zestaw_druga_strona_fiszki = value;
                OnPropertyChanged(nameof(Stwórz_Zestaw_DrugaStronaFiszki));
            }
        }
        public ICommand Stwórz_Zestaw_PrzyciskAnuluj { get; }
        public ICommand Stwórz_Zestaw_PrzyciskStwórz { get; }
        public ICommand Stwórz_Zestaw_PrzyciskDodajFiszkę { get; }
        public StwórzZestaw_ViewModel()
        {

        }
    }
}
