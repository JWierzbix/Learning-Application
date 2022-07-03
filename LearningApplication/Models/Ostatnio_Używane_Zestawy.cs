using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Models
{
    internal class Ostatnio_Używane_Zestawy
    {
        Dictionary<string, Zestaw> ostatnio_używane_zestawy;
        public Ostatnio_Używane_Zestawy(ref Dictionary<string,Zestaw> lista_zestawów)
        {
            ostatnio_używane_zestawy = new Dictionary<string, Zestaw>();
            Uaktualnij_Listę(ref lista_zestawów);
        }
        //do listy zaliczają się zestawy używane 2 tygodnie wstecz
        public void Uaktualnij_Listę(ref Dictionary<string, Zestaw> lista_zestawów)
        {
            var uaktualnione_ostatnio_używane_zestawy = new Dictionary<string, Zestaw>();
            TimeSpan dwa_tygodnie = new TimeSpan(14, 0, 0, 0);
            foreach (var z in lista_zestawów)
            {
                if (DateTime.Now.Subtract(z.Value.data_używania) < dwa_tygodnie)
                {
                    uaktualnione_ostatnio_używane_zestawy.Add(z.Value.nazwa_zestawu, z.Value);
                } 
            }
            ostatnio_używane_zestawy = uaktualnione_ostatnio_używane_zestawy;
        }
    }
}
