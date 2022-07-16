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
    public class StwórzZestaw_ViewModel: ViewModelBase
    {
        private readonly Lista_Zestawów _lista_zestawów;
        public StwórzZestaw_ListaFiszek_ViewModel StwórzZestaw_ListaFiszek { get; }//będziemy pobierać stąd listę fiszek         
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
        public ICommand Stwórz_Zestaw_PrzyciskAnuluj { get; }
        public ICommand Stwórz_Zestaw_PrzyciskStwórz { get; }              
        public StwórzZestaw_ViewModel(NavigationStore navigationStore,Lista_Zestawów lista_zestawów )
        {
            _lista_zestawów = lista_zestawów;
            StwórzZestaw_ListaFiszek = new StwórzZestaw_ListaFiszek_ViewModel(navigationStore,this);
            Stwórz_Zestaw_PrzyciskAnuluj = new StwórzZestaw_ViewModel_AnulujCommand(navigationStore, lista_zestawów);
            Stwórz_Zestaw_PrzyciskStwórz = new Stwórz_Zestaw_PrzyciskStwórzCommand(navigationStore, lista_zestawów, this);            
        }
    }
}
