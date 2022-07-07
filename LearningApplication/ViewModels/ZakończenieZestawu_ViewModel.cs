using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LearningApplication.ViewModels
{
    class ZakończenieZestawu_ViewModel:ViewModelBase
    {
        public ICommand Zakończenie_Zestawu_PowrótDoListyZestawów { get; }
        public ICommand Zakończenie_Zestawu_PowrótDoMenu { get; }
        public ICommand Zakończenie_Zestawu_UczSięOdNowa { get; }
        
        //TRZEBA DODAĆ PASEK POSTĘPU
    }
}
