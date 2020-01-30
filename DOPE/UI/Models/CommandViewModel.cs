using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DOPE.UI.Models
{
	public class CommandViewModel : INotifyPropertyChanged
	{
		public bool Enabled
		{
			[CompilerGenerated]
			get
			{
				return this.<Enabled>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Enabled>k__BackingField == value)
				{
					return;
				}
				this.<Enabled>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Enabled);
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Name);
			}
		}

		public int Id
		{
			[CompilerGenerated]
			get
			{
				return this.<Id>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<Id>k__BackingField == value)
				{
					return;
				}
				this.<Id>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Id);
			}
		}

		[Browsable(false)]
		public int CountReceived
		{
			[CompilerGenerated]
			get
			{
				return this.<CountReceived>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<CountReceived>k__BackingField == value)
				{
					return;
				}
				this.<CountReceived>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.CountTotal);
				this.method_0(<>PropertyChangedEventArgs.RS);
				this.method_0(<>PropertyChangedEventArgs.CountReceived);
			}
		}

		[Browsable(false)]
		public int CountSent
		{
			[CompilerGenerated]
			get
			{
				return this.<CountSent>k__BackingField;
			}
			[CompilerGenerated]
			internal set
			{
				if (this.<CountSent>k__BackingField == value)
				{
					return;
				}
				this.<CountSent>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.RS);
				this.method_0(<>PropertyChangedEventArgs.CountTotal);
				this.method_0(<>PropertyChangedEventArgs.CountSent);
			}
		}

		public int CountTotal
		{
			get
			{
				return this.CountReceived;
			}
		}

		public string RS
		{
			get
			{
				return string.Format("{0}/{1}", this.CountReceived, this.CountSent);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public CommandViewModel()
		{
			Class13.Gj4N3WdzaR1LY();
			this.PropertyChanged = new PropertyChangedEventHandler(CommandViewModel.<>c.<>9.method_0);
			base..ctor();
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_0(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}
	}
}
