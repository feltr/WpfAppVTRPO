using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.Navigations
{
    public class NavigationFinance : ViewModelBase
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set 
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public ModelBase _currentPageViewModel;
        public ModelBase CurrentPageViewModel
        {
            get => _currentPageViewModel;
            set 
            {
                _currentPageViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
