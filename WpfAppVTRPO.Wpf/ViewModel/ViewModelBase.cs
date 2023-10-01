using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.Navigations;

namespace VTRPO.Wpf.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropetryChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public virtual void UpdateResult() { }
        protected ModelBase _model;
        protected NavigationFinance _navigations;
        protected EntryViewModel ExitEntry() 
        {
            return new EntryViewModel(_model, _navigations);
        }
    }
}
