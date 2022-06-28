using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Core
{
    /* ### INFO ###
     * Na tej stronie będzie można stowrzyć zestaw, czyli:
     * - nadać nazwę zestawowi
     * - edytować poszczególne fiszki (dodawać/usuwać)
     * - usunąć zestaw
     */
    public class StwórzZestaw_PageViewModel
    {
        public List<Zestaw_ViewModel> lista_zestawów;
        public Zestaw_ViewModel nowy_zestaw;
        public StwórzZestaw_PageViewModel(ref List<Zestaw_ViewModel> lista_zestawów)
        {
            nowy_zestaw = new Zestaw_ViewModel();
            this.lista_zestawów = lista_zestawów;
        }
        public void Daj_Nazwę(string nazwa_zestawu) => nowy_zestaw.nazwa_zestawu = nazwa_zestawu;
        public void Dodaj_Fiszkę(string pierwsza_strona, string druga_strona)
        {
            Fiszka_ViewModel new_fiszka = new Fiszka_ViewModel(pierwsza_strona, druga_strona);
            nowy_zestaw.Dodaj_Fiszkę(new_fiszka);
        }
        public void Usuń_Fiszkę(int indeks) => nowy_zestaw.Usuń_Fiszkę(indeks);
        //metoda ta dodaje utworzony zestaw do ogólnej listy zestawów na Stronie Głównej
        public void Stwórz_Zestaw()
        {
            //W każdym zestawie musi być przynajmniej 10 fiszek
            if(nowy_zestaw.nazwa_zestawu != null && nowy_zestaw.lista_fiszek.Count >= 4)
            {
                lista_zestawów.Add(nowy_zestaw);
            }
            else
            {
                // musimy dodać wyjątek
            }
        }
    }
}
