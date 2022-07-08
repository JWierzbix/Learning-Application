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
        public IEnumerable<Zestaw_ViewModel> ListaZestawów_Zestawy => _lista_zestawów_zestawy;
        public ListaZestawów_ViewModel()
        {
            _lista_zestawów_zestawy = new ObservableCollection<Zestaw_ViewModel>();
            _lista_zestawów_zestawy.Add(new Zestaw_ViewModel(new Models.Zestaw("zestaw 1", new List<Models.Fiszka>())));
            _lista_zestawów_zestawy.Add(new Zestaw_ViewModel(new Models.Zestaw("zestaw 2", new List<Models.Fiszka>())));
            _lista_zestawów_zestawy.Add(new Zestaw_ViewModel(new Models.Zestaw("zestaw 3", new List<Models.Fiszka>())));
        }
    }
}
