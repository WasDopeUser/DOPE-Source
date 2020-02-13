using System;
using System.Windows.Input;

namespace DOPE.UI.Commands
{
	public class RelayCommand : ICommand
	{
		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}
			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}

		public RelayCommand(Action<object> action_0, Func<object, bool> func_0 = null)
		{
			Class13.igxcIukzfpare();
			base..ctor();
			this.execute = action_0;
			this.canExecute = func_0;
		}

		public bool CanExecute(object parameter)
		{
			return this.canExecute == null || this.canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			this.execute(parameter);
		}

		private Action<object> execute;

		private Func<object, bool> canExecute;
	}
}
