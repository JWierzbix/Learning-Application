using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Models
{
    internal class Lista_Zestawów : IEnumerable<KeyValuePair<string,Zestaw>>
    {
        // słownik składa się z nazyw zestawu i samej instancji zestawu
        private Dictionary<string, Zestaw> lista_zestawów;
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
                return false;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)lista_zestawów).GetEnumerator();
        }
    }
}
