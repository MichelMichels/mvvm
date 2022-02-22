using System;
using System.Diagnostics;
using System.Windows.Input;

namespace MichelMichels.MVVM
{
    public class RelayCommand : ICommand
    {
        readonly Action _execute;
        readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged;

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }        
        public void Execute(object parameter)
        {
            _execute();
        }
    }

    public class RelayCommand<T> : ICommand
    {
        // Fields
        readonly Action<T> _execute;
        readonly Predicate<T> _canExecute;

        // Constructors
        public RelayCommand(Action<T> execute)
        : this(execute, null)
        {
        }
        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }       

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || !(parameter is T) ? true : _canExecute((T)parameter);
        }

        public event EventHandler? CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (parameter is T cast)
            {
                _execute(cast);
            }
        }
    }
}