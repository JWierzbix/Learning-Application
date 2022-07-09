using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class ListaZestawów_ViewModel: ViewModelBase
    {
        public ICommand Lista_Zestawów_Powrót { get; }
        //lista wszystkich zestawów 
        private ObservableCollection<Zestaw_ViewModel> _lista_zestawów_zestawy;
        private Dictionary<string, Models.Zestaw> lista_zestawów;
        public IEnumerable<Zestaw_ViewModel> ListaZestawów_Zestawy => _lista_zestawów_zestawy;
        public ListaZestawów_ViewModel(Stores.NavigationStore navigationStore, Dictionary<string,Models.Zestaw> lista_zestawów)
        {
            _lista_zestawów_zestawy = new ObservableCollection<Zestaw_ViewModel>();            
            Lista_Zestawów_Powrót = new Commands.Lista_Zestawów_PowrótCommand(navigationStore,lista_zestawów);
        }
    }
}
