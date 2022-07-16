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
    public class EdytujZestaw_ViewModel : ViewModelBase
    {
        public EdytujZestaw_ListaFiszek_ViewModel EdytujZestaw_ListaFiszek_ViewModel { get; } //jest napisane dobrze - to ta sama klasa       
        private string _edytuj_zestaw_nazwa_zestawu;
        private string _edytuj_zestaw_stara_nazwa_zestawu;
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
        public EdytujZestaw_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw_ViewModel zestaw_ViewModel)
        {
            _edytuj_zestaw_stara_nazwa_zestawu = zestaw_ViewModel.Zestaw_ViewModel_NazwaZestawu;
            Edytuj_Zestaw_NazwaZestawu = zestaw_ViewModel.Zestaw_ViewModel_NazwaZestawu;
            EdytujZestaw_ListaFiszek_ViewModel = new EdytujZestaw_ListaFiszek_ViewModel(navigationStore,this,zestaw_ViewModel);
            Edytuj_Zestaw_PrzyciskAnuluj = new EdytujZestaw_Anuluj_Command(navigationStore, lista_zestawów);
            Edytuj_Zestaw_PrzyciskZapisz = new EdytujZestaw_PrzyciskZapisz_Command(navigationStore, lista_zestawów, this, _edytuj_zestaw_stara_nazwa_zestawu);
        }
    }
}
