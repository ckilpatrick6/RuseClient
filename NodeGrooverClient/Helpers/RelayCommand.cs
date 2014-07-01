using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NodeGrooverClient.Helpers
{
    public class RelayCommand: ICommand
    {
        public readonly Action<object> _action;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public RelayCommand(Action<object> action)
        {
            _action = action;
        }
    }
}
