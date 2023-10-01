using Accessibility;
using Microsoft.ML.Transforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VTRPO.Library;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Model.Forward;
using VTRPO.Wpf.Model.Precent;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.ViewModel
{
    public class PrecentViewModel : ViewModelBase
    {
        
        private string _Result;
        public string Result
        {
            get 
            {
                return _Result;
            }
            set 
            {
                _Result = value;
                OnPropetryChanged(nameof(Result));
            }
        }
        private Dictionary<string, int> _selectionPrecent = new Dictionary<string, int>()
            {
                {"простой процент", 0},
                {"сложный процент", 1},
                {"непрерывный процент", 2}
            };
        public Dictionary<string, int> SelectionPrecent
        {
            get { return _selectionPrecent; }
            set { _selectionPrecent = value; }
        }
        private KeyValuePair<string, int> _cselectionPrecent;
        public KeyValuePair<string, int> CSelectionPrecent
        {
            get => _cselectionPrecent;
            set
            {
                _cselectionPrecent = value;
                OnPropetryChanged(nameof(CSelectionPrecent));
                OnPropetryChanged(nameof(SelectionYers));
            }
        }
        private Dictionary<string, ModelBase> _selectionYers;
        public Dictionary<string, ModelBase> SelectionYers
        {
            get 
            {
                switch (_cselectionPrecent.Value)
                {
                    case 0:
                        return new Dictionary<string, ModelBase>()
                        {
                            {"при вкладе на 1 год", new OneYersModel()},
                            {"при вкладе более чем на год", new ManyYersModel()},
                            {"при вкладе не кратном одному году", new MultipleYersModel()}
                        };
                    case 1:
                        return new Dictionary<string, ModelBase>()
                        {
                            {"при вкладе более чем на год", new HardPrecentModel()}
                        };
                    case 2:
                        return new Dictionary<string, ModelBase>()
                        {
                            {"при вкладе более чем на год", new СontinuousPrecentModel()}
                        };
                    default:
                        return _selectionYers;
                }
            }
            set 
            {
                _selectionYers = value;
            }
        }
        private KeyValuePair<string, ModelBase> _cselectionYers;
        public KeyValuePair<string, ModelBase> CSelectionYers
        {
            get => _cselectionYers;
            set
            {
                _cselectionYers = value;
                _model = value.Value;
                _navigations.CurrentPageViewModel = _model;
                OnPropetryChanged(nameof(CSelectionPrecent));
            }
        }
        public ModelBase CurrentPageViewModel => _navigations.CurrentPageViewModel;
        public ICommand PrecentCommand { get; set; }
        public ICommand ExitCommand { get; }
        public ICommand ResultCommand => new GetResultCommand(arg => DoExecuteClickCommand(_model));
        public ICommand DiagramCommand { get; }
        public PrecentViewModel(ModelBase model, NavigationFinance navigation)
        {
            _model = model;
            _navigations = navigation;
            ExitCommand = new NavigateCommand(_navigations, ExitEntry);
            DiagramCommand = new NavigateCommand(_navigations, ViewDiagram);
            _navigations.CurrentViewModelChanged += OnCurrentModelChanged;
            _navigations.CurrentPageViewModel = null;
        }
        private void DoExecuteClickCommand(ModelBase model)
        {
            Result = model.Result.ToString();
            OnPropetryChanged(nameof(Result));
        }
        private void OnCurrentModelChanged()
        {
            OnPropetryChanged(nameof(CurrentPageViewModel));
        }
        private ViewModelBase ViewDiagram() 
        {
            double item = _model.PV;
            switch (CSelectionPrecent.Value) 
            {
                case 0:
                    return new DiagramViewModel(_model, _navigations,_model.PV, double.Parse(_Result) - _model.PV);
                case 1:
                    item = (double)Finance.CalcInvestment(_model.PV, _model.r, _model.n);
                    return new DiagramViewModel(_model, _navigations, _model.PV, item - _model.PV ,(double)_model.Result - item);
                case 2:
                    item = (double)Finance.CalcInvestment(_model.PV, _model.r, _model.t);
                    return new DiagramViewModel(_model, _navigations, _model.PV, item - _model.PV, (double)_model.Result - item);
            }
            return new DiagramViewModel(_model, _navigations);
        }
    }
}
