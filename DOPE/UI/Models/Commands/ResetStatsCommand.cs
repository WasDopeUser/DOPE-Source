using System;
using System.Windows.Input;

namespace DOPE.UI.Models.Commands
{
	public class ResetStatsCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return parameter is GClass882;
		}

		public void Execute(object parameter)
		{
			GClass882 gclass = parameter as GClass882;
			gclass.Reset();
			gclass.Started = new DateTime?(DateTime.Now);
		}

		public ResetStatsCommand()
		{
			Class13.lOBHd9Nzn7x2T();
			this.CanExecuteChanged = new EventHandler(ResetStatsCommand.<>c.<>9.method_0);
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ResetStatsCommand()
		{
			Class13.lOBHd9Nzn7x2T();
			ResetStatsCommand.Instance = new ResetStatsCommand();
		}

		public static readonly ICommand Instance;
	}
}
