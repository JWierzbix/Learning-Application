using LearningApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.ViewModels
{
    class StwórzZestaw_ListaFiszek_ViewModel: ViewModelBase
    {
        private readonly ObservableCollection<Fiszka_ViewModel> _stwórzZestaw_ListaFiszek;
        public IEnumerable<Fiszka_ViewModel> StwórzZestaw_ListaFiszek => _stwórzZestaw_ListaFiszek;
        public StwórzZestaw_ListaFiszek_ViewModel(Lista_Zestawów lista_zestawów)
        {
            _stwórzZestaw_ListaFiszek = new ObservableCollection<Fiszka_ViewModel>();
            _stwórzZestaw_ListaFiszek.Add(new Fiszka_ViewModel(new Models.Fiszka("cow", "krowa"),lista_zestawów, this));
        }
    }
}
