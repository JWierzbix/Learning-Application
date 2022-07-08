﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class EdytujZestaw_ViewModel : ViewModelBase
    {
        private ObservableCollection<Fiszka_ViewModel> _edytuj_zestaw_lista_fiszek;
        public IEnumerable<Fiszka_ViewModel> Edytuj_Zestaw_ListaFiszek => _edytuj_zestaw_lista_fiszek;
        private string _edytuj_zestaw_nazwa_zestawu;
        public string Edytuj_Zestaw_NazwaZestawu
        {
            get
            {
                return _edytuj_zestaw_nazwa_zestawu;
            }
            set
            {
                _edytuj_zestaw_nazwa_zestawu = value;
                OnPropertyChanged(nameof(Edytuj_Zestaw_NazwaZestawu));
            }
        }
        private string _edytuj_zestaw_pierwsza_strona_fiszki;
        public string Edytuj_Zestaw_PierwszaStronaFiszki
        {
            get
            {
                return _edytuj_zestaw_pierwsza_strona_fiszki;
            }
            set
            {
                _edytuj_zestaw_pierwsza_strona_fiszki = value;
                OnPropertyChanged(nameof(Edytuj_Zestaw_PierwszaStronaFiszki));
            }
        }
        private string _edytuj_zestaw_druga_strona_fiszki;
        public string Edytuj_Zestaw_DrugaStronaFiszki
        {
            get
            {
                return _edytuj_zestaw_druga_strona_fiszki;
            }
            set
            {
                _edytuj_zestaw_druga_strona_fiszki = value;
                OnPropertyChanged(nameof(Edytuj_Zestaw_DrugaStronaFiszki));
            }
        }
        public ICommand Edytuj_Zestaw_PrzyciskAnuluj { get; }
        public ICommand Edytuj_Zestaw_PrzyciskZapisz { get; }
        public ICommand Edytuj_Zestaw_PrzyciskDodajFiszkę { get; }
        public EdytujZestaw_ViewModel()
        {
            _edytuj_zestaw_lista_fiszek = new ObservableCollection<Fiszka_ViewModel>();
        }
    }
}
