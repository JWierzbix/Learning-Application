using LearningApplication.Exceptions;
using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearningApplication.Commands
{
    class Zestaw_ViewModel_UczSię_Command: CommandBase
    {
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        private Zestaw _zestaw;
        public Zestaw_ViewModel_UczSię_Command(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, Zestaw zestaw)
        {
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
            _zestaw = zestaw;
        }
        public override void Execute(object parameter)
        {
            try
            {
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
            catch (ZaMałoFiszekException)
            {
                MessageBox.Show("W tym zestawie jest za mało fiszek do rozpoczęcia nauki! Potrzebujesz minimum 4 fiszki.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
