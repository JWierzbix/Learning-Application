using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Core
{
    public class Zestaw_ViewModel
    {
        public string nazwa_zestawu { get; set; }
        public List<Fiszka_ViewModel> lista_fiszek;
        public DateTime data_utworzenia;        
        public Zestaw_ViewModel()
        {
            this.nazwa_zestawu = nazwa_zestawu;
            data_utworzenia = DateTime.Now;
            lista_fiszek = new List<Fiszka_ViewModel>();
        }
        public int Poziom_Ukończenia()
        {
            int licznik = 0;
            foreach(Fiszka_ViewModel f in lista_fiszek)
            {
                if(f.nauczone == true) licznik++;
            }
            double procent = (double)licznik / lista_fiszek.Count;
            return (int)(procent * 100);
        }
        public void WyczyśćPostępy()
        {
            foreach(Fiszka_ViewModel f in lista_fiszek)
            {
                f.nauczone = false;
            }
        }        
        public void Dodaj_Fiszkę(Fiszka_ViewModel fiszka) => lista_fiszek.Add(fiszka);
        public void Usuń_Fiszkę(int indeks)
        {
            lista_fiszek.RemoveAt(indeks);
        }
        public void Edytuj_Fiszkę(int indeks, string pierwsza_strona, string druga_strona)
        {
            lista_fiszek[indeks].pierwsza_strona = pierwsza_strona;
            lista_fiszek[indeks].druga_strona = druga_strona;
        }        
    }
}
