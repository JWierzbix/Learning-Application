using LearningApplication.Exceptions;
using LearningApplication.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Models
{
    public class Lista_Zestawów : IEnumerable<KeyValuePair<string,Zestaw>>
    {
        // słownik składa się z nazyw zestawu i samej instancji zestawu
        public Dictionary<string, Zestaw> lista_zestawów { get; }           
        public Lista_Zestawów()
        {
            lista_zestawów = new Dictionary<string, Zestaw>();
        }
        public bool CzyPusta()
        {
            if (lista_zestawów.Count == 0)
                return true;
            else return false;
        }        
        public IEnumerator<KeyValuePair<string, Zestaw>> GetEnumerator()
        {
            return lista_zestawów.GetEnumerator();
        }

        public void UsuńZestaw(string nazwa_zestawu) => lista_zestawów.Remove(nazwa_zestawu);
        public bool Utwórz_Zestaw(string nazwa_zestawu, List<Fiszka> lista_fiszek)
        {
            //jeżeli nasza lista zestawów nie posiada zestawu z taką nazwą jaką wpisaliśmy, dopiero wtedy możemy utworzyć zestaw
            if (!lista_zestawów.ContainsKey(nazwa_zestawu))
            {
                Zestaw nowy_zestaw = new Zestaw(nazwa_zestawu, lista_fiszek);
                lista_zestawów.Add(nazwa_zestawu, nowy_zestaw);
                return true;
            }
            else
            {
                throw new DuplikatException(lista_zestawów[nazwa_zestawu],nazwa_zestawu);
            }
        }
        public bool Edytuj_Zestaw(string stara_nazwa_zestawu,string nowa_nazwa_zestawu, List<Fiszka> lista_fiszek)
        {
            //jeżeli nasza lista zestawów nie posiada zestawu z taką nazwą jaką wpisaliśmy, dopiero wtedy możemy utworzyć zestaw
            if (!lista_zestawów.ContainsKey(nowa_nazwa_zestawu) || stara_nazwa_zestawu==nowa_nazwa_zestawu)
            {
                lista_zestawów[stara_nazwa_zestawu].Zmień_Nazwę(nowa_nazwa_zestawu);
                Zestaw z = new Zestaw(nowa_nazwa_zestawu,lista_fiszek);
                lista_zestawów.Remove(stara_nazwa_zestawu);
                lista_zestawów.Add(nowa_nazwa_zestawu, z);
                lista_zestawów[nowa_nazwa_zestawu].EdytowanoZestaw();
                return true;
            }
            else
            {
                return false;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)lista_zestawów).GetEnumerator();
        }
        public static Dictionary<string, Zestaw> OstatnioUżywaneZestawy(Dictionary<string, Zestaw> lista_zestawów)
        {
            var uaktualnione_ostatnio_używane_zestawy = new Dictionary<string, Zestaw>();
            TimeSpan dwa_tygodnie = new TimeSpan(14, 0, 0, 0);
            foreach (var z in lista_zestawów)
            {
                if (DateTime.Now.Subtract(z.Value.Data_Używania) < dwa_tygodnie)
                {
                    uaktualnione_ostatnio_używane_zestawy.Add(z.Value.nazwa_zestawu, z.Value);
                }
            }
            return uaktualnione_ostatnio_używane_zestawy;
        }
    }
}
