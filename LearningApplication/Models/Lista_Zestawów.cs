using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Models
{
    internal class Lista_Zestawów
    {
        // słownik składa się z nazyw zestawu i samej instancji zestawu
        public Dictionary<string, Zestaw> lista_zestawów;
        public Lista_Zestawów()
        {
            lista_zestawów = new Dictionary<string, Zestaw>();
        }
        public void Utwórz_Zestaw(string nazwa_zestawu, List<Fiszka> lista_fiszek)
        {
            //jeżeli nasza lista zestawów nie posiada zestawu z taką nazwą jaką wpisaliśmy, dopiero wtedy możemy utworzyć zestaw
            if (!lista_zestawów.ContainsKey(nazwa_zestawu))
            {
                Zestaw nowy_zestaw = new Zestaw(nazwa_zestawu, lista_fiszek);
                lista_zestawów.Add(nazwa_zestawu, nowy_zestaw);
            }
            else
            {
                //wyskakuje komunikat
            }
        }
    }
}
