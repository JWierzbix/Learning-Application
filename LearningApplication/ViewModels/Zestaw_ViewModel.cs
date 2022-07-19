using LearningApplication.Commands;
using LearningApplication.Models;
using LearningApplication.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    public class Zestaw_ViewModel: ViewModelBase
    {        
        private Models.Zestaw _zestaw;
        public List<Fiszka> Lista_Fiszek => _zestaw.lista_fiszek;
        public ICommand Zestaw_ViewModel_UczSię { get; }
        public ICommand Zestaw_ViewModel_WyczyśćPostępy { get; }
        public ICommand Zestaw_ViewModel_Edytuj { get; }
        public ICommand Zestaw_ViewModel_Usuń { get; }
        public string Zestaw_ViewModel_NazwaZestawu => _zestaw.nazwa_zestawu;
        public double PoziomUkończenia
        {
            get
            {
                if (_zestaw.lista_fiszek.Count != 0) return _zestaw.Poziom_Ukończenia();
                else return 0;                
            }
        }
        public Zestaw_ViewModel(Models.Zestaw zestaw, NavigationStore navigationStore,Lista_Zestawów lista_zestawów)
        {
            _zestaw = zestaw;            
            Zestaw_ViewModel_UczSię = new Zestaw_ViewModel_UczSię_Command(navigationStore,lista_zestawów,zestaw);
            Zestaw_ViewModel_WyczyśćPostępy = new Zestaw_ViewModel_WyczyśćPostępy_Command(navigationStore,lista_zestawów,_zestaw);
            Zestaw_ViewModel_Edytuj = new Zestaw_ViewModel_Edytuj_Command(navigationStore,lista_zestawów,this);
            Zestaw_ViewModel_Usuń = new Zestaw_ViewModel_Usuń_Command(navigationStore,lista_zestawów,zestaw);
        }
    }
}
