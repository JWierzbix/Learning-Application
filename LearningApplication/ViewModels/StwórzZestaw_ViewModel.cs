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
        private readonly Lista_Zestawów _lista_zestawów;
        private readonly ObservableCollection<Fiszka_ViewModel> _stwórz_zestaw_lista_fiszek;
        public IEnumerable<Fiszka_ViewModel> StwórzZestaw_ListaFiszek
        {
            get => _stwórz_zestaw_lista_fiszek;               
        }
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
        public StwórzZestaw_ViewModel(Stores.NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _lista_zestawów = lista_zestawów;
            _stwórz_zestaw_lista_fiszek = new ObservableCollection<Fiszka_ViewModel>();            
            Stwórz_Zestaw_PrzyciskAnuluj = new Commands.StwórzZestaw_ViewModel_AnulujCommand(navigationStore,_lista_zestawów);
            Stwórz_Zestaw_PrzyciskStwórz = new Commands.Stwórz_Zestaw_PrzyciskStwórzCommand(this, navigationStore,_lista_zestawów);
            Stwórz_Zestaw_PrzyciskDodajFiszkę = new Commands.Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(this, navigationStore, _lista_zestawów);
        }
        public StwórzZestaw_ViewModel(Stores.NavigationStore navigationStore, Lista_Zestawów lista_zestawów, IEnumerable<Fiszka_ViewModel> lista_fiszek, string nazwa_zestawu)
        {
            _lista_zestawów = lista_zestawów;
            _stwórz_zestaw_lista_fiszek = new ObservableCollection<Fiszka_ViewModel>();
            foreach(var item in lista_fiszek)
            {
                _stwórz_zestaw_lista_fiszek.Add(item);
            }
            Stwórz_Zestaw_NazwaZestawu = nazwa_zestawu;
            Stwórz_Zestaw_PrzyciskAnuluj = new Commands.StwórzZestaw_ViewModel_AnulujCommand(navigationStore, _lista_zestawów);
            Stwórz_Zestaw_PrzyciskStwórz = new Commands.Stwórz_Zestaw_PrzyciskStwórzCommand(this, navigationStore, _lista_zestawów);
            Stwórz_Zestaw_PrzyciskDodajFiszkę = new Commands.Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(this, navigationStore, _lista_zestawów);
        }
    }
}
