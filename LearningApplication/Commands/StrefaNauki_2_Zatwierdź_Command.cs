using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace LearningApplication.Commands
{
    class StrefaNauki_2_Zatwierdź_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        private StrefaNauki_2_ViewModel _strefaNauki_2_ViewModel;
        public StrefaNauki_2_Zatwierdź_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw, StrefaNauki_2_ViewModel strefaNauki_2_ViewModel)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
            _strefaNauki_2_ViewModel = strefaNauki_2_ViewModel;
        }
        public override void Execute(object parameter)
        {
            if (!_lista_zestawów.lista_zestawów[_zestaw.nazwa_zestawu].UdzielOdpowiedź(_strefaNauki_2_ViewModel.Strefa_Nauki_2_Odpowiedź))
            {
                MessageBox.Show($"Poprawna Odppowiedź: {_zestaw.Odpowiedź}", "BŁĘDNA ODPOWIEDŹ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
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
