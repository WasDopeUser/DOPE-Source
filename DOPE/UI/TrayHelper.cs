using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;

namespace DOPE.UI
{
	public class TrayHelper
	{
		public TrayHelper(MainWindow mainWindow_0)
		{
			Class13.nIxas2ezryi9b();
			base..ctor();
			this.mainWindow = mainWindow_0;
			mainWindow_0.StateChanged += this.method_0;
			this.ni = new NotifyIcon();
			Stream stream = System.Windows.Application.GetResourceStream(new Uri("pack://application:,,,/DOPE;component/dope.ico")).Stream;
			this.ni.Icon = new Icon(stream);
			this.ni.Text = "DOPE";
			this.ni.Visible = false;
			this.ni.Click += this.ni_DoubleClick;
			this.ni.DoubleClick += this.ni_DoubleClick;
			this._menu = new ContextMenu();
		}

		private void method_0(object sender, EventArgs e)
		{
			if (this.mainWindow.WindowState == WindowState.Minimized)
			{
				this.ni.Visible = true;
				this.mainWindow.Hide();
			}
		}

		public void method_1(string string_0, string string_1)
		{
			this.ni.BalloonTipTitle = string_0;
			this.ni.BalloonTipText = string_1;
			this.ni.BalloonTipIcon = ToolTipIcon.None;
			this.ni.Visible = true;
			this.ni.ShowBalloonTip(30000);
			this.ni.BalloonTipClicked += this.ni_BalloonTipClicked;
		}

		private void method_2(object sender, EventArgs e)
		{
			this.mainWindow.Close();
		}

		private void ni_DoubleClick(object sender, EventArgs e)
		{
			this.mainWindow.Show();
			this.mainWindow.WindowState = WindowState.Normal;
			this.mainWindow.Activate();
			this.ni.Visible = false;
		}

		[CompilerGenerated]
		private void ni_BalloonTipClicked(object sender, EventArgs e)
		{
			this.mainWindow.Show();
			this.mainWindow.Activate();
		}

		private readonly MainWindow mainWindow;

		private ContextMenu _menu;

		private NotifyIcon ni;
	}
}
