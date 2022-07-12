using LearningApplication.Commands;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.ViewModels
{
    class ListaZestawów_ListaZestawów_ViewModel: ViewModelBase
    {
        private readonly ObservableCollection<Zestaw_ViewModel> _listaZestawów_ListaZestawów;        
        public IEnumerable<Zestaw_ViewModel> ListaZestawów_ListaZestawów => _listaZestawów_ListaZestawów;
        public ListaZestawów_ListaZestawów_ViewModel(NavigationStore navigationStore)
        {
            _listaZestawów_ListaZestawów = new ObservableCollection<Zestaw_ViewModel>();
            _listaZestawów_ListaZestawów.Add(new Zestaw_ViewModel(new Models.Zestaw("zestaw 2", new List<Models.Fiszka>()), navigationStore));            
        }
    }
}
