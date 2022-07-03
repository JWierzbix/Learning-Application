using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Fiszki.Core
{
    /* ### INFO ###
     * Na tej stronie będzie:
     * - przycisk stworzenia nowego zestawu
     * - przejścia do listy dostępnych zestawów do nauki
     * - lista ostatnio używanych zestawów  z podanym statusem/procentem ukończenia ich 
     */
    public class StronaGłówna_PageViewModel
    {
        public List<Zestaw_ViewModel> lista_zestawów;
        public StronaGłówna_PageViewModel( )
        {
            lista_zestawów = new List<Zestaw_ViewModel>();            
        }
        public void Utwórz_Nowy_Zestaw()//przenosi nas do odpowiedniej strony
        {
            new StwórzZestaw_PageViewModel(ref lista_zestawów);
        }
        
    }
}
