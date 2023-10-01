using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationFinance _navigationFinance;
        public ViewModelBase CurrentViewModel => _navigationFinance.CurrentViewModel;
        public MainViewModel(NavigationFinance navigationFinance) 
        { 
            _navigationFinance = navigationFinance;

            _navigationFinance.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropetryChanged(nameof(CurrentViewModel));
        }
    }
}
