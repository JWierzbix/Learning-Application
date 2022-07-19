using LearningApplication.Commands;
using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    public class StwórzZestaw_ListaFiszek_ViewModel: ViewModelBase
    {
        private ObservableCollection<Fiszka_ViewModel> _stwórzZestaw_ListaFiszek;        
        public IEnumerable<Fiszka_ViewModel> StwórzZestaw_ListaFiszek
        {
            get => _stwórzZestaw_ListaFiszek;
            set
            {
                _stwórzZestaw_ListaFiszek = (ObservableCollection<Fiszka_ViewModel>)value;
                OnPropertyChanged(nameof(StwórzZestaw_ListaFiszek));
            }
        }
        public ICommand Stwórz_Zestaw_PrzyciskDodajFiszkę { get; }
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
        public StwórzZestaw_ListaFiszek_ViewModel(NavigationStore navigationStore)
        {
            _stwórzZestaw_ListaFiszek = new ObservableCollection<Fiszka_ViewModel>();            
            Stwórz_Zestaw_PrzyciskDodajFiszkę = new Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(navigationStore,this);
        }
    }
}
