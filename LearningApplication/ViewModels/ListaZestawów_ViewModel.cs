using LearningApplication.Models;
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
        private Lista_Zestawów _lista_zestawów;
        public IEnumerable<Zestaw_ViewModel> ListaZestawów_Zestawy => _lista_zestawów_zestawy;
        public ListaZestawów_ViewModel(Stores.NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _lista_zestawów_zestawy = new ObservableCollection<Zestaw_ViewModel>();
            _lista_zestawów = lista_zestawów;
            UaktualnijListę();
            Lista_Zestawów_Powrót = new Commands.Lista_Zestawów_PowrótCommand(navigationStore,lista_zestawów);
        }
        public void UaktualnijListę()
        {
            if (_lista_zestawów.CzyPusta()) { }
            else
            {
                foreach(var item in _lista_zestawów)
                {
                    _lista_zestawów_zestawy.Add(new Zestaw_ViewModel(item.Value));
                }
            }
        }
    }
}
