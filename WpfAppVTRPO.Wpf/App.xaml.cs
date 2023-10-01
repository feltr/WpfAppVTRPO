using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ModelBase _model;
        private readonly NavigationFinance _navigationFinance;
        public App() 
        { 
            _navigationFinance = new NavigationFinance();
            _model = new ModelBase();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationFinance.CurrentViewModel = new EntryViewModel(_model, _navigationFinance);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationFinance)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
