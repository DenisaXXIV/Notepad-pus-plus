using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notepad_Plus_Plus.Commands
{
    internal class RelayCommandParameterless
    {
        readonly Action _execute;
        readonly Func<bool> _canExecute;

        public RelayCommandParameterless(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new NullReferenceException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommandParameterless(Action execute) : this(execute, null)
        {

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}
