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
    class Stwórz_Zestaw_PrzyciskDodajFiszkęCommand : CommandBase
    {
        private StwórzZestaw_ViewModel _stwórz_zestaw_view_model;
        private NavigationStore _navigationStore;
        private Lista_Zestawów _lista_zestawów;
        public Stwórz_Zestaw_PrzyciskDodajFiszkęCommand(StwórzZestaw_ViewModel stwórz_zestaw_view_model, NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            _stwórz_zestaw_view_model = stwórz_zestaw_view_model;
            _navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów;
        }

        public override void Execute(object parameter)
        {
            Fiszka_ViewModel nowa_fiszka = new Fiszka_ViewModel(new Models.Fiszka(
                _stwórz_zestaw_view_model.Stwórz_Zestaw_PierwszaStronaFiszki,
                _stwórz_zestaw_view_model.Stwórz_Zestaw_DrugaStronaFiszki
                ));
            var nowa_lista_fiszek = (ObservableCollection<Fiszka_ViewModel>)_stwórz_zestaw_view_model.StwórzZestaw_ListaFiszek;
            nowa_lista_fiszek.Add(nowa_fiszka);
            _navigationStore.CurrentViewModel = new StwórzZestaw_ViewModel(_navigationStore, _lista_zestawów,nowa_lista_fiszek, _stwórz_zestaw_view_model.Stwórz_Zestaw_NazwaZestawu);   
        }
    }
}
