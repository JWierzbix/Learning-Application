using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fiszki.Core;
namespace Fiszki
{
    /// <summary>
    /// Logika interakcji dla klasy StwórzZestaw_Page.xaml
    /// </summary>
    public partial class StwórzZestaw_Page : Page
    {
        public StwórzZestaw_Page(ref List<Zestaw_ViewModel> lista_zestawów)
        {
            InitializeComponent();
            DataContext = new StwórzZestaw_PageViewModel(ref lista_zestawów);
        }
    }
}
