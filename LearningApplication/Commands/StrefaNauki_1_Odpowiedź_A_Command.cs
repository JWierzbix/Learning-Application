using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class StrefaNauki_1_Odpowiedź_A_Command : CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        private string[] _dane;
        private StrefaNauki_1_ViewModel _strefaNauki_1_ViewModel;
        public StrefaNauki_1_Odpowiedź_A_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw,string[] dane,StrefaNauki_1_ViewModel strefaNauki_1_ViewModel)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
            _dane = dane;
            _strefaNauki_1_ViewModel = strefaNauki_1_ViewModel;           
        }        
        public override void Execute(object parameter)
        {
            _lista_zestawów.lista_zestawów[_zestaw.nazwa_zestawu].UdzielOdpowiedź(_dane[0]);
            string[] dane = _lista_zestawów.lista_zestawów[_zestaw.nazwa_zestawu].GenerujEtap();
            if (dane.Length == 4)
            {
                _navigationStore.CurrentViewModel = new StrefaNauki_1_ViewModel(_navigationStore, _lista_zestawów, _zestaw, dane);
            }
            else if (dane.Length == 0)
            {
                _navigationStore.CurrentViewModel = new StrefaNauki_2_ViewModel(_navigationStore, _lista_zestawów, _zestaw);
            }
            else if (dane.Length == 2)
            {
                _navigationStore.CurrentViewModel = new KamieńMilowy_ViewModel(_navigationStore, _lista_zestawów, _zestaw);
            }
            else if (dane.Length == 3)
            {
                _navigationStore.CurrentViewModel = new ZakończenieZestawu_ViewModel(_navigationStore, _lista_zestawów, _zestaw);
            }
        }
    }
}
