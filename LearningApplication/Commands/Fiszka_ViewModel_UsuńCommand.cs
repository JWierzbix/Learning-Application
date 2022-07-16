using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class Fiszka_ViewModel_UsuńCommand: CommandBase
    {
        private Fiszka_ViewModel _fiszka;
        private StwórzZestaw_ListaFiszek_ViewModel _stwórzZestaw_ListaFiszek_ViewModel;
        public Fiszka_ViewModel_UsuńCommand(Fiszka_ViewModel fiszka, StwórzZestaw_ListaFiszek_ViewModel stwórzZestaw_ListaFiszek_ViewModel)
        {
            _fiszka = fiszka;
            _stwórzZestaw_ListaFiszek_ViewModel = stwórzZestaw_ListaFiszek_ViewModel;
        }

        public override void Execute(object parameter)
        {
            ((ObservableCollection<Fiszka_ViewModel>)_stwórzZestaw_ListaFiszek_ViewModel.StwórzZestaw_ListaFiszek).Remove(_fiszka);            
        }
    }
}
