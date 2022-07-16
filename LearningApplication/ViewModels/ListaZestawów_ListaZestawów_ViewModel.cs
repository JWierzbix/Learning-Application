using LearningApplication.Commands;
using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.ViewModels
{
    public class ListaZestawów_ListaZestawów_ViewModel: ViewModelBase
    {
        private ObservableCollection<Zestaw_ViewModel> _listaZestawów_ListaZestawów;        
        public IEnumerable<Zestaw_ViewModel> ListaZestawów_ListaZestawów
        {
            get => _listaZestawów_ListaZestawów;
            set
            {
                _listaZestawów_ListaZestawów = (ObservableCollection<Zestaw_ViewModel>)value;
                OnPropertyChanged(nameof(ListaZestawów_ListaZestawów));
            }
        }
        public ListaZestawów_ListaZestawów_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _listaZestawów_ListaZestawów = Helpers.Function.ZamieńNaCollectionZestawów(lista_zestawów, navigationStore);      
        }        
    }
}
