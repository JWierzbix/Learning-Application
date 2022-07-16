using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Helpers
{
    public static class Function
    {
        public static ObservableCollection<Zestaw_ViewModel> ZamieńNaCollectionZestawów(Lista_Zestawów stara_lista_zestawów, NavigationStore navigationStore)
        {
            var nowa_lista = new ObservableCollection<Zestaw_ViewModel>();
            foreach (var item in stara_lista_zestawów)
            {
                Zestaw_ViewModel z = new Zestaw_ViewModel(item.Value, navigationStore,stara_lista_zestawów);
                nowa_lista.Add(z);
            }
            return nowa_lista;
        }
        public static List<Fiszka> ZamieńNaListęFiszek(IEnumerable<Fiszka_ViewModel> stara_lista)
        {
            List<Fiszka> nowa_lista = new List<Fiszka>();
            foreach (var item in stara_lista)
            {
                Fiszka f = new Fiszka(item.Fiszka_ViewModel_PierwszaStrona, item.Fiszka_ViewModel_DrugaStrona);
                nowa_lista.Add(f);
            }
            return nowa_lista;
        }
    }
}
