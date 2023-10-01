using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.ViewModel
{
    public class EntryViewModel : ViewModelBase
    {
        public ICommand EntryPrecentCommand { get; }
        public ICommand EntryForwardCommand { get; }
        public ICommand EntryBondCommand { get; }
        public ICommand HelpCommand { get; }
        public EntryViewModel(ModelBase model, NavigationFinance navigation) 
        {
            _model = model;
            _navigations = navigation;
            EntryPrecentCommand = new NavigateCommand(_navigations, CreatePrecent);
            EntryForwardCommand = new NavigateCommand(_navigations, CreateForward);
            EntryBondCommand = new NavigateCommand(_navigations, CreateBond);
        }
        private PrecentViewModel CreatePrecent() 
        {
            return new PrecentViewModel(_model, _navigations);
        }
        private ForwardViewModel CreateForward()
        {
            return new ForwardViewModel(_model, _navigations);
        }
        private BondViewModel CreateBond()
        {
            return new BondViewModel(_model, _navigations);
        }
    }
}
