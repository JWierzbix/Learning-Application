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
        private string _nazwa_zestawu;
        public string NazwaZestawu
        {
            get
            {
                return _nazwa_zestawu;
            }
            set
            {
                _nazwa_zestawu = value;
                OnPropertyChanged(nameof(NazwaZestawu));
            }
        }
        private string pierwsza_strona_fiszki;
        public string PierwszaStronaFiszki
        {
            get
            {
                return pierwsza_strona_fiszki;
            }
            set
            {
                pierwsza_strona_fiszki = value;
                OnPropertyChanged(nameof(PierwszaStronaFiszki));
            }
        }
        
        private string druga_strona_fiszki;
        public string DrugaStronaFiszki
        {
            get
            {
                return druga_strona_fiszki;
            }
            set
            {
                druga_strona_fiszki = value;
                OnPropertyChanged(nameof(DrugaStronaFiszki));
            }
        }
        public ICommand PrzyciskAnuluj { get; }
        public ICommand PrzyciskStwórz { get; }
        public ICommand PrzyciskDodajFiszkę { get; }
        public StwórzZestaw_ViewModel()
        {

        }
    }
}
