using System;
using System.Windows.Input;

namespace DOPE.UI.Models.Commands
{
	public class ResetStatsCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return parameter is GClass816;
		}

		public void Execute(object parameter)
		{
			GClass816 gclass = parameter as GClass816;
			gclass.Reset();
			gclass.Started = new DateTime?(DateTime.Now);
		}

		public ResetStatsCommand()
		{
			Class13.igxcIukzfpare();
			this.CanExecuteChanged = new EventHandler(ResetStatsCommand.<>c.<>9.method_0);
			base..ctor();
		}

		// Note: this type is marked as 'beforefieldinit'.
		static ResetStatsCommand()
		{
			Class13.igxcIukzfpare();
			ResetStatsCommand.Instance = new ResetStatsCommand();
		}

		public static readonly ICommand Instance;
	}
}
