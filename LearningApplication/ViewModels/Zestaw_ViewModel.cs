using LearningApplication.Commands;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class Zestaw_ViewModel: ViewModelBase
    {        
        private Models.Zestaw _zestaw;
        public ICommand Zestaw_ViewModel_UczSię { get; }
        public ICommand Zestaw_ViewModel_WyczyśćPostępy { get; }
        public ICommand Zestaw_ViewModel_Edytuj { get; }
        public ICommand Zestaw_ViewModel_Usuń { get; }
        public string Zestaw_ViewModel_NazwaZestawu => _zestaw.nazwa_zestawu;
        public Zestaw_ViewModel(Models.Zestaw zestaw, NavigationStore navigationStore)
        {
            _zestaw = zestaw;            
            Zestaw_ViewModel_UczSię = new Zestaw_ViewModel_UczSię_Command(navigationStore);
            Zestaw_ViewModel_WyczyśćPostępy = new Zestaw_ViewModel_WyczyśćPostępy_Command(navigationStore);
            Zestaw_ViewModel_Edytuj = new Zestaw_ViewModel_Edytuj_Command(navigationStore);
            Zestaw_ViewModel_Usuń = new Zestaw_ViewModel_Usuń_Command(navigationStore);
        }
    }
}
