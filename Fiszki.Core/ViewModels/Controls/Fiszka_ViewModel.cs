using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki.Core
{
    public class Fiszka_ViewModel
    {
        public string pierwsza_strona { get; set; }//zobaczy jak aplikacja się rozwinie, w razie czego zmieni się klasę object
        public string druga_strona{ get; set; }
        public bool nauczone { get; set; }
        public Fiszka_ViewModel(string pierwsza_strona, string druga_strona)
        {
            this.pierwsza_strona = pierwsza_strona;
            this.druga_strona = druga_strona;
        }
    }
}
