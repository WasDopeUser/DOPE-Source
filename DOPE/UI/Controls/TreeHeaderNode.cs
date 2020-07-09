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
				this.method_1(<>PropertyChangedEventArgs.Id);
				this.method_1(<>PropertyChangedEventArgs.Name);
				this.method_1(<>PropertyChangedEventArgs.Enabled);
				this.method_1(<>PropertyChangedEventArgs.Command);
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
				this.method_1(<>PropertyChangedEventArgs.Timestamp);
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
				this.method_1(<>PropertyChangedEventArgs.Received);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public TreeHeaderNode(CommandViewModel commandViewModel_0, DateTime dateTime_0, bool bool_0)
		{
			Class13.lOBHd9Nzn7x2T();
			this.PropertyChanged = new PropertyChangedEventHandler(TreeHeaderNode.<>c.<>9.method_0);
			base..ctor();
			this.Command = commandViewModel_0;
			this.Timestamp = dateTime_0;
			this.Received = bool_0;
			commandViewModel_0.PropertyChanged += this.method_0;
		}

		private void method_0(object sender, PropertyChangedEventArgs e)
		{
			this.Command = this.Command;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void method_1(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}
	}
}
