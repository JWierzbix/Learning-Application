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
    class StronaGłówna_OstatnioUżywaneZestawy_ViewModel: ViewModelBase
    {
        private ObservableCollection<Zestaw_ViewModel> _stronaGłówna_OstatnioUżywaneZestawy;        
        public IEnumerable<Zestaw_ViewModel> StronaGłówna_OstatnioUżywaneZestawy_Component
        {
            get => _stronaGłówna_OstatnioUżywaneZestawy;
            set
            {
                _stronaGłówna_OstatnioUżywaneZestawy = (ObservableCollection<Zestaw_ViewModel>)value;
                OnPropertyChanged(nameof(StronaGłówna_OstatnioUżywaneZestawy_Component));
            }
        }
        public StronaGłówna_OstatnioUżywaneZestawy_ViewModel(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            Dictionary<string, Zestaw> słownik_zestawów = Lista_Zestawów.OstatnioUżywaneZestawy(lista_zestawów.lista_zestawów);
            _stronaGłówna_OstatnioUżywaneZestawy = new ObservableCollection<Zestaw_ViewModel>();
            foreach(var item in słownik_zestawów)
            {
                Zestaw_ViewModel z = new Zestaw_ViewModel(item.Value, navigationStore, lista_zestawów);
                _stronaGłówna_OstatnioUżywaneZestawy.Add(z);
            }
        }
    }
}
