using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FastReport;
using FastReport.Export.PdfSimple;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Model.Forward;

namespace VTRPO.Wpf.Commands
{
    public class CreateReportForwardCommand : CommandBase
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        public override void Execute(object parameter)
        {
            _execute(parameter);
            /*Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
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
            FReport.RegisterData(_product, "Products");
            FReport.Prepare();
            PDFSimpleExport pDFSimpleExport = new PDFSimpleExport();
            FReport.Export(pDFSimpleExport, dlg.FileName);
            FReport.Dispose();
            MessageBox.Show("отчет создан");*/
        }
        public CreateReportForwardCommand(Action<object> execute) 
            :this(execute, null)
        { 
        }
        public CreateReportForwardCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute"); //NOTTOTRANS

            _execute = execute;
            _canExecute = canExecute;
        }
    }
}
