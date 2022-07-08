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
        public ICommand Strona_Główna_StwórzZestaw { get; }
        public ICommand Strona_Główna_WybierzZestaw { get; }
        //lista zestawów na stronie głównej
        private ObservableCollection<Zestaw_ViewModel> _strona_główna_ostatnio_odwiedzane_zestawy;
        public IEnumerable<Zestaw_ViewModel> StronaGłówna_OdwiedzoneZestawy => _strona_główna_ostatnio_odwiedzane_zestawy;
        public StronaGłówna_ViewModel()
        {
            _strona_główna_ostatnio_odwiedzane_zestawy = new ObservableCollection<Zestaw_ViewModel>();
        }
    }
}
