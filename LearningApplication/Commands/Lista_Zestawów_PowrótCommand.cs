﻿using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApplication.Commands
{
    class Lista_Zestawów_PowrótCommand: CommandBase
    {
        private readonly NavigationStore navigationStore;
        private readonly Lista_Zestawów _lista_zestawów;
        public Lista_Zestawów_PowrótCommand(NavigationStore navigationStore, Lista_Zestawów lista_zestawów)
        {
            this.navigationStore = navigationStore;
            _lista_zestawów = lista_zestawów; 
        }

        public override void Execute(object parameter)
        {
            navigationStore.CurrentViewModel = new ViewModels.StronaGłówna_ViewModel(navigationStore,_lista_zestawów );
        }
    }
}
