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
    class StronaGłówna_ViewModel: ViewModelBase
    {
        private readonly Lista_Zestawów _lista_zestawów;
        public ICommand Strona_Główna_StwórzZestaw { get; }
        public ICommand Strona_Główna_WybierzZestaw { get; }
        //lista zestawów na stronie głównej
        private readonly ObservableCollection<Zestaw_ViewModel> _strona_główna_ostatnio_odwiedzane_zestawy;
        public IEnumerable<Zestaw_ViewModel> StronaGłówna_OdwiedzoneZestawy => _strona_główna_ostatnio_odwiedzane_zestawy;
        public StronaGłówna_ViewModel(Stores.NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _lista_zestawów = lista_zestawów;
            _strona_główna_ostatnio_odwiedzane_zestawy = new ObservableCollection<Zestaw_ViewModel>();
            Strona_Główna_StwórzZestaw = new Commands.Strona_Główna_StwórzZestaw_Command(navigationStore, _lista_zestawów);
            Strona_Główna_WybierzZestaw = new Commands.Strona_Główna_WybierzZestaw_Command(navigationStore,_lista_zestawów);            
        }
    }
}
