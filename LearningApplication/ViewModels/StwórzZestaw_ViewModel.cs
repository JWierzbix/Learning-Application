using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class StwórzZestaw_ViewModel: ViewModelBase
    {
        private Dictionary<string, Models.Zestaw> _lista_zestawów;
        private ObservableCollection<Fiszka_ViewModel> _stwórz_zestaw_lista_fiszek;
        public IEnumerable<Fiszka_ViewModel> StwórzZestaw_ListaFiszek => _stwórz_zestaw_lista_fiszek;
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
        public StwórzZestaw_ViewModel(Stores.NavigationStore navigationStore, Dictionary<string, Models.Zestaw> lista_zestawów)
        {
            _lista_zestawów = lista_zestawów;
            _stwórz_zestaw_lista_fiszek = new ObservableCollection<Fiszka_ViewModel>();
            _stwórz_zestaw_lista_fiszek.Add(new Fiszka_ViewModel(new Models.Fiszka("krowa", "cow")));
            _stwórz_zestaw_lista_fiszek.Add(new Fiszka_ViewModel(new Models.Fiszka("słoń", "elephant")));
            _stwórz_zestaw_lista_fiszek.Add(new Fiszka_ViewModel(new Models.Fiszka("kurczak", "chicken")));
            Stwórz_Zestaw_PrzyciskAnuluj = new Commands.StwórzZestaw_ViewModel_AnulujCommand(navigationStore,_lista_zestawów);
        }
    }
}
