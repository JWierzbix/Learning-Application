using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Core
{
    /* ### INFO ###
     * Ta strona będzie poświęcona nauce fiszek.
     * Składowe elementy:
     * - pytanie typu  4 odpowiedzi abcd/uzupełnij lukę 
     * - przycisk, aby przejść dalej
     * - przycisk, aby zakończyć naukę i powrócić do menu głównego
     * - przycisk, aby zakończyć naukę i powrócić do listy zestawów      
     * - przycisk, aby zacząć naukę od nowa 
     * - pasek postępu
     */
    internal class LearningSection_PageViewModel
    {
        Zestaw_ViewModel zestaw;
        public LearningSection_PageViewModel(Zestaw_ViewModel zestaw)
        {
            this.zestaw = zestaw;
        }
        public void Rozpocznij_Nauke()
        {

        }
    }
}
