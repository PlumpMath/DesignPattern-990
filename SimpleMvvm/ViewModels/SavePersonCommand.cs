using System;
using System.Windows.Input;

namespace SimpleMvvm.ViewModels
{
    public class SavePersonCommand: ICommand
    {
        private Action _executeMethod;

        public SavePersonCommand(Action updatePerson)
        {
            _executeMethod = updatePerson;
        }

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _executeMethod.Invoke();
        }

        #endregion
    }
}