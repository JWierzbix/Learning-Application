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
    public class EdytujZestaw_ListaFiszek_ViewModel: ViewModelBase
    {
        private ObservableCollection<Fiszka_ViewModel> _edytujZestaw_ListaFiszek;
        public IEnumerable<Fiszka_ViewModel> EdytujZestaw_ListaFiszek
        {
            get => _edytujZestaw_ListaFiszek;
            set
            {
                _edytujZestaw_ListaFiszek = (ObservableCollection<Fiszka_ViewModel>)value;
                OnPropertyChanged(nameof(EdytujZestaw_ListaFiszek));
            }
        }
        public ICommand EdytujZestaw_PrzyciskDodajFiszkę { get; }
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
        public EdytujZestaw_ListaFiszek_ViewModel(NavigationStore navigationStore, EdytujZestaw_ViewModel edytujZestaw_ViewModel,Zestaw_ViewModel zestaw_ViewModel)
        {
            _edytujZestaw_ListaFiszek = new ObservableCollection<Fiszka_ViewModel>();
            foreach(var item in zestaw_ViewModel.Lista_Fiszek)
            {
                Fiszka f = new Fiszka(item.pierwsza_strona, item.druga_strona);
                Fiszka_ViewModel ff = new Fiszka_ViewModel(f, this);
                _edytujZestaw_ListaFiszek.Add(ff);
            }
            EdytujZestaw_PrzyciskDodajFiszkę = new EdytujZestaw_PrzyciskDodajFiszkę_Command(navigationStore, this);
        }
    }
}
