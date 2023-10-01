using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationFinance _navigationFinance;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigateCommand(NavigationFinance navigationFinance, Func<ViewModelBase> createViewModel)
        {
            _navigationFinance = navigationFinance;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _navigationFinance.CurrentViewModel = _createViewModel();
        }
    }
}
