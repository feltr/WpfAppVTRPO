using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VTRPO.Library;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Model.Precent;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.ViewModel
{
    public class DiagramViewModel : ViewModelBase
    {
        public ICommand PieClickCommand { get; }
        public ChartValues<ObservableValue> PointDeposit { get; set; }
        public ChartValues<ObservableValue> PointEasy { get; set; }
        public ChartValues<ObservableValue> PointHard { get; set; }
        public ICommand ExitCommand { get; }
        public DiagramViewModel(ModelBase model, NavigationFinance navigation,double pointDeposit = 0, double pointEasy = 0, double pointHard = 0)
        {
            _model = model;
            _navigations = navigation;
            ExitCommand = new NavigateCommand(_navigations, ExitPrecent);
            PointDeposit = new ChartValues<ObservableValue> { new ObservableValue(pointDeposit) };
            PointEasy = new ChartValues<ObservableValue> { new ObservableValue(pointEasy) };
            PointHard = new ChartValues<ObservableValue> { new ObservableValue(pointHard) };
            OnPropetryChanged(nameof(PointDeposit));
            OnPropetryChanged(nameof(PointEasy));
            OnPropetryChanged(nameof(PointHard));
        }
        public ViewModelBase ExitPrecent() 
        {
            return new PrecentViewModel(_model,_navigations);
        }
    }
}
