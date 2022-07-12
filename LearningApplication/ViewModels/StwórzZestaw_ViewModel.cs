using LearningApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    internal class StwórzZestaw_ViewModel: ViewModelBase
    {
        public StwórzZestaw_ListaFiszek_ViewModel StwórzZestaw_ListaFiszek { get; }                
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
        public StwórzZestaw_ViewModel(Stores.NavigationStore navigationStore)
        {
            StwórzZestaw_ListaFiszek = new StwórzZestaw_ListaFiszek_ViewModel();
            Stwórz_Zestaw_PrzyciskAnuluj = new Commands.StwórzZestaw_ViewModel_AnulujCommand(navigationStore);
            Stwórz_Zestaw_PrzyciskStwórz = new Commands.Stwórz_Zestaw_PrzyciskStwórzCommand(this,navigationStore);
            Stwórz_Zestaw_PrzyciskDodajFiszkę = new Commands.Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(this,navigationStore);
        }
    }
}
