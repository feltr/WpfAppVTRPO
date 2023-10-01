using Accessibility;
using FastReport.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Model.Bond;
using VTRPO.Wpf.Navigations;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.ViewModel
{
    public class BondViewModel : ViewModelBase
    {

        private double _GCO;
        public double GCO
        {
            get
            {
                return _GCO;
            }
            set
            {
                //_model.GCO = value;
                _GCO = value;
                OnPropetryChanged(nameof(GCO));
            }
        }
        private double _NCD;
        public double NCD
        {
            get
            {
                return _NCD;
            }
            set
            {
                _model.NCD = value;
                _NCD = value;
                OnPropetryChanged(nameof(NCD));
            }
        }
        private double _N;
        public double N
        {
            get
            {
                return _N;
            }
            set
            {
                _model = new CuponIncomeModel();
                _model.N = value;
                _N = value;
                OnPropetryChanged(nameof(N));
            }
        }
        private double _r;
        public double r
        {
            get
            {
                return _r;
            }
            set
            {
                _model.r = value;
                _r = value;
                OnPropetryChanged(nameof(r));
            }
        }
        private DateTime _Dn;
        public DateTime Dn
        {
            get
            {
                return _Dn;
            }
            set
            {
                _model.Dn = value;
                _Dn = value;
                OnPropetryChanged(nameof(Dn));
            }
        }
        private DateTime _Do;
        public DateTime Do
        {
            get
            {
                return _Do;
            }
            set
            {
                _model.Do = value;
                _Do = value;
                OnPropetryChanged(nameof(Do));
            }
        }
        private int _n;
        public int n
        {
            get
            {
                return _n;
            }
            set
            {
                _model.n = value;
                _n = value;
                OnPropetryChanged(nameof(n));

            }
        }
        private double _C;
        public double C
        {
            get
            {
                return _C;
            }
            set
            {
                _model.C = value;
                _C = value;
                OnPropetryChanged(nameof(C));
            }
        }
        private double _y;
        public double y
        {
            get
            {
                return _y;
            }
            set
            {
                _model.y = value;
                _y = value;
                OnPropetryChanged(nameof(y));
            }
        }
        private double _M;
        public double M
        {
            get
            {
                return _M;
            }
            set
            {
                _model.M = value;
                _M = value;
                OnPropetryChanged(nameof(M));
            }
        }
        private double _P;
        public double P
        {
            get
            {
                return _P;
            }
            set
            {
                _model.P = value;
                _P = value;
                OnPropetryChanged(nameof(P));
            }
        }
        private double _UpP;
        public double UpP
        {
            get
            {
                return _UpP;
            }
            set
            {
                _model.UpP = value;
                _UpP = value;
                OnPropetryChanged(nameof(UpP));
            }
        }
        private double _DownP;
        public double DownP
        {
            get
            {
                return _DownP;
            }
            set
            {
                _model.DownP = value;
                _DownP = value;
                OnPropetryChanged(nameof(DownP));
            }
        }
        private double _UpI;
        public double UpI
        {
            get
            {
                return _UpI;
            }
            set
            {
                _model.UpI = value;
                _UpI = value;
                OnPropetryChanged(nameof(UpI));
            }
        }
        private double _DownI;
        public double DownI
        {
            get
            {
                return _DownI;
            }
            set
            {
                _model.DownI = value;
                _DownI = value;
                OnPropetryChanged(nameof(DownI));
            }
        }
        private string _Result;
        public string Result
        {
            get
            {
                return _Result;
            }
            set
            {
                _Result = _model?.Result.ToString();
            }
        }
        private Dictionary<string, ModelBase> _selectionItem = new Dictionary<string, ModelBase>()
            {
                {"текущая стоимость облигации, купонной", new CuponModel()},
                {"текущая стоимость облигации, дисконтной", new DiscountModel()},
                {"чистая цена облигации", new BondPriceModel()},
                {"накопленный купонный доход", new CuponIncomeModel()},
                {"дюрация Маколея", new MacaulayDurationModel()},
                {"модифицированная дюрация", new MacaulayDurationModificirModel()},
                {"эффективная дюрация", new MacaulayDurationEffectivModel()}
            };
        public Dictionary<string, ModelBase> SelectionItem
        {
            get { return _selectionItem; }
            set { _selectionItem = value; }
        }
        private KeyValuePair<string, ModelBase> _cselectionItem;
        public KeyValuePair<string, ModelBase> CSelectionItem 
        { 
            get => _cselectionItem;
            set
            {
                _model = value.Value;
                _cselectionItem = value;
                _navigations.CurrentPageViewModel = _model;
                OnPropetryChanged(nameof(CSelectionItem));
            }
        }
        public ModelBase CurrentPageViewModel => _navigations.CurrentPageViewModel;
        public ICommand ContextCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand ResultCommand => new GetResultCommand(arg => DoExecuteClickCommand(_model));
        public BondViewModel(ModelBase model, NavigationFinance navigation) 
        {
            _navigations = navigation;
            _model = model;
            ContextCommand = new SelectItemCommand();
            ExitCommand = new NavigateCommand(_navigations, ExitEntry);
            _navigations.CurrentViewModelChanged += OnCurrentModelChanged;
            _navigations.CurrentPageViewModel = null;
        }
        public override void UpdateResult() 
        {
            OnPropetryChanged(nameof(Result));
        }
        private void OnCurrentModelChanged()
        {
            OnPropetryChanged(nameof(CurrentPageViewModel));
        }
        private void DoExecuteClickCommand(ModelBase model)
        {
            Result = model.Result.ToString();
            OnPropetryChanged(nameof(Result));
        }
    }
}
