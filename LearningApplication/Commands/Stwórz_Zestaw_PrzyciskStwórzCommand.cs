using LearningApplication.Exceptions;
using LearningApplication.Helpers;
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
    class Stwórz_Zestaw_PrzyciskStwórzCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly StwórzZestaw_ViewModel _stwórzZestaw_ViewModel;//potrzebne są dane
        private Lista_Zestawów _lista_zestawów;
               
        public Stwórz_Zestaw_PrzyciskStwórzCommand(NavigationStore navigationStore, Lista_Zestawów lista_zestawów, StwórzZestaw_ViewModel stwórzZestaw_ViewModel)
        {
            _lista_zestawów = lista_zestawów;
            _stwórzZestaw_ViewModel = stwórzZestaw_ViewModel;            
            _navigationStore = navigationStore;            
        }
        public override void Execute(object parameter)
        {
            //tworzymy odpowiedni typ listy fiszek do dodawania
            List<Fiszka> nowa_lista = Function.ZamieńNaListęFiszek(_stwórzZestaw_ViewModel.StwórzZestaw_ListaFiszek.StwórzZestaw_ListaFiszek);
            try
            {
                _lista_zestawów.Utwórz_Zestaw(_stwórzZestaw_ViewModel.Stwórz_Zestaw_NazwaZestawu, nowa_lista);
                _navigationStore.CurrentViewModel = new ListaZestawów_ViewModel(_navigationStore, _lista_zestawów);
            }
            catch(DuplikatException)
            {
                MessageBox.Show("Zestaw o takiej nazwie został już utworzony. Prosimy o zmianę nazwy zestawu.","Błąd",MessageBoxButton.OK,MessageBoxImage.Error);
            }       
            
        }
        
    }
}
