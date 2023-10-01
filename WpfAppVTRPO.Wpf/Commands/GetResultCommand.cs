using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using VTRPO.Wpf.Commands;
using VTRPO.Wpf.Model;
using VTRPO.Wpf.ViewModel;

namespace VTRPO.Wpf.Commands
{
    public class GetResultCommand : CommandBase
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;
        public override void Execute(object parameter)
        {
            _execute(parameter);
        }
        public GetResultCommand(Action<object> execute)
                : this(execute, null)
        {
        }
        public GetResultCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute"); //NOTTOTRANS

            _execute = execute;
            _canExecute = canExecute;
        }
    }
}
