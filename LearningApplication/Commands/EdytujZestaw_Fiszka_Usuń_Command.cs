using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class EdytujZestaw_Fiszka_Usuń_Command: CommandBase
    {
        private Fiszka_ViewModel _fiszka;
        private EdytujZestaw_ListaFiszek_ViewModel _edytujZestaw_ListaFiszek_ViewModel;
        public EdytujZestaw_Fiszka_Usuń_Command(Fiszka_ViewModel fiszka, EdytujZestaw_ListaFiszek_ViewModel edytujZestaw_ListaFiszek_ViewModel)
        {
            _fiszka = fiszka;
            _edytujZestaw_ListaFiszek_ViewModel = edytujZestaw_ListaFiszek_ViewModel;
        }

        public override void Execute(object parameter)
        {
            ((ObservableCollection<Fiszka_ViewModel>)_edytujZestaw_ListaFiszek_ViewModel.EdytujZestaw_ListaFiszek).Remove(_fiszka);
        }
    }
}
