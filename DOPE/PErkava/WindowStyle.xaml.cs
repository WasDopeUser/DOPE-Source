using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace PErkava
{
	public partial class WindowStyle : ResourceDictionary, IStyleConnector
	{
		public WindowStyle()
		{
			Class13.igxcIukzfpare();
			base..ctor();
			this.InitializeComponent();
		}

		private void npUotNoEfLA(object sender, RoutedEventArgs e)
		{
			((Window)((FrameworkElement)sender).TemplatedParent).Close();
		}

		private void method_0(object sender, RoutedEventArgs e)
		{
			Window window = (Window)((FrameworkElement)sender).TemplatedParent;
			if (window.WindowState == WindowState.Normal)
			{
				window.WindowState = WindowState.Maximized;
				return;
			}
			window.WindowState = WindowState.Normal;
		}

		private void method_1(object sender, RoutedEventArgs e)
		{
			((Window)((FrameworkElement)sender).TemplatedParent).WindowState = WindowState.Minimized;
		}

		private void eJfotUryaMm(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hello!");
		}

		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			if (connectionId == 1)
			{
				((Button)target).Click += this.method_1;
				return;
			}
			if (connectionId != 2)
			{
				return;
			}
			((Button)target).Click += this.npUotNoEfLA;
		}
	}
}
