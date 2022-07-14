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
    internal class StwórzZestaw_ViewModel: ViewModelBase
    {
        private readonly Lista_Zestawów _lista_zestawów;
        public StwórzZestaw_ListaFiszek_ViewModel StwórzZestaw_ListaFiszek { get; set; }                
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
        public StwórzZestaw_ViewModel(NavigationStore navigationStore,Lista_Zestawów lista_zestawów )
        {
            _lista_zestawów = lista_zestawów;
            StwórzZestaw_ListaFiszek = new StwórzZestaw_ListaFiszek_ViewModel(lista_zestawów);
            Stwórz_Zestaw_PrzyciskAnuluj = new StwórzZestaw_ViewModel_AnulujCommand(navigationStore, lista_zestawów);
            Stwórz_Zestaw_PrzyciskStwórz = new Stwórz_Zestaw_PrzyciskStwórzCommand(navigationStore, lista_zestawów, this);
            Stwórz_Zestaw_PrzyciskDodajFiszkę = new Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(navigationStore,lista_zestawów );
        }
    }
}
