using System;
using System.Windows.Input;

namespace DOPE.UI.Models.Commands
{
	public class ResetStatsCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return parameter is GClass815;
		}

		public void Execute(object parameter)
		{
			GClass815 gclass = parameter as GClass815;
			gclass.Reset();
			gclass.Started = new DateTime?(DateTime.Now);
		}

		public ResetStatsCommand()
		{
			Class13.Gj4N3WdzaR1LY();
			this.CanExecuteChanged = new EventHandler(ResetStatsCommand.<>c.<>9.method_0);
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ResetStatsCommand()
		{
			Class13.Gj4N3WdzaR1LY();
			ResetStatsCommand.Instance = new ResetStatsCommand();
		}

		public static readonly ICommand Instance;
	}
}
