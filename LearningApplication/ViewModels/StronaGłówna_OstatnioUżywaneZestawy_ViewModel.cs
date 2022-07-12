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
    class StronaGłówna_OstatnioUżywaneZestawy_ViewModel: ViewModelBase
    {
        private readonly ObservableCollection<Zestaw_ViewModel> _stronaGłówna_OstatnioUżywaneZestawy;        
        public IEnumerable<Zestaw_ViewModel> StronaGłówna_OstatnioUżywaneZestawy => _stronaGłówna_OstatnioUżywaneZestawy;
        public StronaGłówna_OstatnioUżywaneZestawy_ViewModel(NavigationStore navigationStore)
        {            
            _stronaGłówna_OstatnioUżywaneZestawy = new ObservableCollection<Zestaw_ViewModel>();
            _stronaGłówna_OstatnioUżywaneZestawy.Add(new Zestaw_ViewModel(new Models.Zestaw("zestaw 1", new List<Models.Fiszka>()), navigationStore));
        }
    }
}
