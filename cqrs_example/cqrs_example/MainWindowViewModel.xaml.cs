using System;
using System.Windows.Input;

namespace cqrs_example
{
    public class MainWindowViewModel
    {
        public ICommand ClickCommand { get; private set; }

        public MainWindowViewModel()
        {
            ClickCommand = new ClickingCommand();
        }
    }

    public class ClickingCommand : ICommand
    {
        public void Execute(object parameter)
        {

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}