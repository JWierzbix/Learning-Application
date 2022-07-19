using LearningApplication.Exceptions;
using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearningApplication.Commands
{
    class Stwórz_Zestaw_PrzyciskDodajFiszkęCommand : CommandBase
    {        
        private NavigationStore _navigationStore;        
        private StwórzZestaw_ListaFiszek_ViewModel _stwórzZestaw_ListaFiszek_ViewModel;        
        public Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(NavigationStore navigationStore, StwórzZestaw_ListaFiszek_ViewModel stwórzZestaw_ListaFiszek_ViewModel)
        {
            _navigationStore = navigationStore;
            _stwórzZestaw_ListaFiszek_ViewModel = stwórzZestaw_ListaFiszek_ViewModel;
        }
        public override void Execute(object parameter)
        {
            string pierwsza_strona = _stwórzZestaw_ListaFiszek_ViewModel.Stwórz_Zestaw_PierwszaStronaFiszki;
            string druga_strona = _stwórzZestaw_ListaFiszek_ViewModel.Stwórz_Zestaw_DrugaStronaFiszki;
            try
            {
                foreach (var item in _stwórzZestaw_ListaFiszek_ViewModel.StwórzZestaw_ListaFiszek)
                {
                    if (item.Fiszka_ViewModel_PierwszaStrona == pierwsza_strona && item.Fiszka_ViewModel_DrugaStrona == druga_strona)
                    {
                        throw new DuplikatException();
                    }
                }
                Fiszka f = new Fiszka(pierwsza_strona, druga_strona);
                Fiszka_ViewModel ff = new Fiszka_ViewModel(f, _stwórzZestaw_ListaFiszek_ViewModel);
                ((ObservableCollection<Fiszka_ViewModel>)_stwórzZestaw_ListaFiszek_ViewModel.StwórzZestaw_ListaFiszek).Add(ff);
            }
            catch (DuplikatException)
            {
                MessageBox.Show("Istnieje już fiszka z podanymi parametrami! Prosimy o podanie nowych parametrów.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            _stwórzZestaw_ListaFiszek_ViewModel.Stwórz_Zestaw_PierwszaStronaFiszki = "";
            _stwórzZestaw_ListaFiszek_ViewModel.Stwórz_Zestaw_DrugaStronaFiszki = "";
        }
    }
}
