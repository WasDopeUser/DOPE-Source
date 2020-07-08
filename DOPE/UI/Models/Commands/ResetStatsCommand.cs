using System;
using System.Windows.Input;
using xcwaDuiebvuNrIkSlmL;

namespace DOPE.UI.Models.Commands
{
	public class ResetStatsCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return parameter is GClass881;
		}

		public void Execute(object parameter)
		{
			GClass881 gclass = parameter as GClass881;
			gclass.Reset();
			gclass.Started = new DateTime?(DateTime.Now);
		}

		public ResetStatsCommand()
		{
			Class13.xnk8ImWzpOt04();
			this.CanExecuteChanged = new EventHandler(ResetStatsCommand.<>c.<>9.method_0);
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ResetStatsCommand()
		{
			Class13.xnk8ImWzpOt04();
			ResetStatsCommand.Instance = new ResetStatsCommand();
		}

		public static readonly ICommand Instance;
	}
}
