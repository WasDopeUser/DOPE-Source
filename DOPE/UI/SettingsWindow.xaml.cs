using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DOPE.Common.Packets;
using DOPE.Core;

namespace DOPE.UI
{
	public partial class SettingsWindow : Window, INotifyPropertyChanged
	{
		public string NewKey
		{
			[CompilerGenerated]
			get
			{
				return this.<NewKey>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<NewKey>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<NewKey>k__BackingField = value;
				this.method_2(<>PropertyChangedEventArgs.NewKey);
			}
		}

		public Controller Controller
		{
			[CompilerGenerated]
			get
			{
				return this.<Controller>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Controller>k__BackingField, value))
				{
					return;
				}
				this.<Controller>k__BackingField = value;
				this.method_2(<>PropertyChangedEventArgs.Controller);
			}
		}

		public string DisconnectReason
		{
			[CompilerGenerated]
			get
			{
				return this.<DisconnectReason>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<DisconnectReason>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<DisconnectReason>k__BackingField = value;
				this.method_2(<>PropertyChangedEventArgs.DisconnectReason);
			}
		}

		public SettingsWindow(Controller controller_0)
		{
			Class13.tMHx78BzgCM8j();
			this.PropertyChanged = new PropertyChangedEventHandler(SettingsWindow.<>c.<>9.method_0);
			base..ctor();
			this.InitializeComponent();
			this.Controller = controller_0;
			base.DataContext = this;
			this.NewKey = controller_0.Key;
			controller_0.method_2(new EventHandler<S2C_ConnectionClosed>(this.method_0));
		}

		~SettingsWindow()
		{
			if (this.Controller != null)
			{
				this.Controller.method_3(new EventHandler<S2C_ConnectionClosed>(this.method_0));
			}
		}

		private void method_0(object object_0, S2C_ConnectionClosed s2C_ConnectionClosed_0)
		{
			if (s2C_ConnectionClosed_0.Reason == ConnectionClosedReason.ConnectionReset)
			{
				this.DisconnectReason = "Your DOPE account already has a connected bot client. If you think this is a mistake, please see the F.A.Q.";
				return;
			}
			if (s2C_ConnectionClosed_0.Reason == ConnectionClosedReason.KeyExpired)
			{
				this.DisconnectReason = "You do not have any active licenses. In order to use the bot, please purchase a license first.";
				return;
			}
			this.DisconnectReason = string.Format("Connection failure: {0}", s2C_ConnectionClosed_0.Reason);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void method_1(object sender, RoutedEventArgs e)
		{
			string newKey = this.NewKey;
			if (newKey != null && newKey.Length == 36)
			{
				this.Controller.method_6(this.NewKey);
				return;
			}
			MessageBox.Show("Invalid key");
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_2(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}
	}
}
