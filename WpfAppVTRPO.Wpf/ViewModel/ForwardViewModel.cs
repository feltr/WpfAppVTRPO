using FastReport.Export.PdfSimple;
using FastReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Model.Bond;
using VTRPO.Wpf.Model.Forward;
using VTRPO.Wpf.Navigations;
using System.Windows;

namespace VTRPO.Wpf.ViewModel
{
    public class ForwardViewModel : ViewModelBase
    {
        private List<CurrenciesModel> _currencies = new List<CurrenciesModel>();
        private List<ProductModel> _products = new List<ProductModel>();
        private double _S;
        public double S
        { 
            get 
            { 
                return _S; 
            } 
            set 
            { 
                _S = value;
                OnPropetryChanged(nameof(S));
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
                _r = value;
                OnPropetryChanged(nameof(r));
            }
        }

        private double _rf;
        public double rf
        {
            get
            {
                return _rf;
            }
            set
            {
                _rf = value;
                OnPropetryChanged(nameof(rf));
            }
        }

        private double _T;
        public double T
        {
            get
            {
                return _T;
            }
            set
            {
                _T = value;
                OnPropetryChanged(nameof(T));
            }
        }

        private double _dayV;
        public double dayV
        {
            get
            {
                return _dayV;
            }
            set
            {
                _dayV = value;
                OnPropetryChanged(nameof(dayV));
            }
        }
        

       
       
        private double _Z;
        public double Z
        {
            get
            {
                return _Z;
            }
            set
            {
                _Z = value;
                OnPropetryChanged(nameof(Z));
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
                _Result = value;
                OnPropetryChanged(nameof(Result));
            }
        }

        private Dictionary<string, ModelBase> _selectionItem = new Dictionary<string, ModelBase>()
            {
                {"Расчет валюты", new CurrenciesModel()},
                {"Расчет товара", new ProductModel()}
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
        public ICommand ReportCommand => new CreateReportForwardCommand(arg => DoExecuteReportCommand());
        public ICommand ExitCommand { get; }
        public ICommand ResultCommand => new GetResultCommand(arg => DoExecuteClickCommand(_model));


        public ForwardViewModel(ModelBase model, NavigationFinance navigation)
        {
            _model = model;
            _navigations = navigation;
            ExitCommand = new NavigateCommand(_navigations, ExitEntry);
            _navigations.CurrentViewModelChanged += OnCurrentModelChanged;
            _navigations.CurrentPageViewModel = null;
        }
        private void OnCurrentModelChanged()
        {
            OnPropetryChanged(nameof(CurrentPageViewModel));
        }
        private void DoExecuteClickCommand(ModelBase model)
        {
            if (model is CurrenciesModel)
                _currencies.Add((CurrenciesModel)model.Clone());
            if (model is ProductModel)
                _products.Add((ProductModel)model.Clone());
            Result = model.Result.ToString();
            OnPropetryChanged(nameof(Result));
        }
        private void DoExecuteReportCommand() 
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".pdf";
            dlg.Filter = "Text documents (.pdf)|*.pdf";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
            }
            Report FReport = new Report();
            FReport.Load(@"Report\Forward.frx");
            FReport.RegisterData(_currencies, "Currencies");
            FReport.RegisterData(_products, "Products");
            FReport.Prepare();
            PDFSimpleExport pDFSimpleExport = new PDFSimpleExport();
            FReport.Export(pDFSimpleExport, dlg.FileName);
            FReport.Dispose();
            MessageBox.Show("отчет создан");
        }
    }
}
