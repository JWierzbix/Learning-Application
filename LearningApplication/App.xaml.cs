using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using LearningApplication.Models;
using LearningApplication.Stores;
using LearningApplication.ViewModels;

namespace LearningApplication
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Dictionary<string, Zestaw> lista_zestawów;
        private NavigationStore _navigationStore;
        public App()
        {
            lista_zestawów = new Dictionary<string, Zestaw>();
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new StronaGłówna_ViewModel(_navigationStore, lista_zestawów);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
