using System;
using System.Windows.Input;

namespace DOPE.UI.Models.Commands
{
	public class ResetStatsCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return parameter is GClass814;
		}

		public void Execute(object parameter)
		{
			GClass814 gclass = parameter as GClass814;
			gclass.Reset();
			gclass.Started = new DateTime?(DateTime.Now);
		}

		public ResetStatsCommand()
		{
			Class13.tMHx78BzgCM8j();
			this.CanExecuteChanged = new EventHandler(ResetStatsCommand.<>c.<>9.method_0);
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ResetStatsCommand()
		{
			Class13.tMHx78BzgCM8j();
			ResetStatsCommand.Instance = new ResetStatsCommand();
		}

		public static readonly ICommand Instance;
	}
}
