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
        public ListaZestawów_ListaZestawów_ViewModel ListaZestawów_ListaZestawów_ViewModel { get; }
        public ICommand Lista_Zestawów_Powrót { get; }
        //lista wszystkich zestawów 
        public ListaZestawów_ViewModel(Stores.NavigationStore navigationStore)
        {
            ListaZestawów_ListaZestawów_ViewModel = new ListaZestawów_ListaZestawów_ViewModel(navigationStore);
            Lista_Zestawów_Powrót = new Commands.Lista_Zestawów_PowrótCommand(navigationStore);
        }        
    }
}
