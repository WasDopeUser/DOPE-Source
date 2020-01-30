using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DOPE.UI.Models;

namespace DOPE.UI.Controls
{
	public class TreeHeaderNode : TreeNode, INotifyPropertyChanged
	{
		public CommandViewModel Command
		{
			[CompilerGenerated]
			get
			{
				return this.<Command>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				this.<Command>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Id);
				this.method_0(<>PropertyChangedEventArgs.Name);
				this.method_0(<>PropertyChangedEventArgs.Enabled);
				this.method_0(<>PropertyChangedEventArgs.Command);
			}
		}

		public DateTime Timestamp
		{
			[CompilerGenerated]
			get
			{
				return this.<Timestamp>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (DateTime.Equals(this.<Timestamp>k__BackingField, value))
				{
					return;
				}
				this.<Timestamp>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Timestamp);
			}
		}

		public int Id
		{
			get
			{
				return this.Command.Id;
			}
		}

		public override string Name
		{
			get
			{
				return this.Command.Name;
			}
		}

		public bool Enabled
		{
			get
			{
				return this.Command.Enabled;
			}
		}

		public bool Received
		{
			[CompilerGenerated]
			get
			{
				return this.<Received>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Received>k__BackingField == value)
				{
					return;
				}
				this.<Received>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Received);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public TreeHeaderNode(CommandViewModel commandViewModel_0, DateTime dateTime_0, bool bool_0)
		{
			Class13.Gj4N3WdzaR1LY();
			this.PropertyChanged = new PropertyChangedEventHandler(TreeHeaderNode.<>c.<>9.eiFpQoedjU);
			base..ctor();
			this.Command = commandViewModel_0;
			this.Timestamp = dateTime_0;
			this.Received = bool_0;
			commandViewModel_0.PropertyChanged += this.hkApOrRaaT;
		}

		private void hkApOrRaaT(object sender, PropertyChangedEventArgs e)
		{
			this.Command = this.Command;
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
