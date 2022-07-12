using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.ViewModels
{
    class EdytujZestaw_ListaFiszek_ViewModel: ViewModelBase
    {
        private readonly ObservableCollection<Fiszka_ViewModel> _edytujZestaw_ListaFiszek;
        public IEnumerable<Fiszka_ViewModel> EdytujZestaw_LisaFiszek => _edytujZestaw_ListaFiszek;
        public EdytujZestaw_ListaFiszek_ViewModel()
        {
            _edytujZestaw_ListaFiszek = new ObservableCollection<Fiszka_ViewModel>();
            _edytujZestaw_ListaFiszek.Add(new Fiszka_ViewModel(new Models.Fiszka("oko", "eye")));
        }
    }
}
