using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DOPE.UI.Controls
{
	public class SimpleTreeNode : INotifyPropertyChanged
	{
		public virtual string Name
		{
			[CompilerGenerated]
			get
			{
				return this.<Name>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Name>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Name>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Name);
			}
		}

		public virtual string Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Value>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Value>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Value);
			}
		}

		public List<SimpleTreeNode> Children
		{
			[CompilerGenerated]
			get
			{
				return this.<Children>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Children>k__BackingField, value))
				{
					return;
				}
				this.<Children>k__BackingField = value;
				this.method_0(<>PropertyChangedEventArgs.Children);
			}
		}

		public SimpleTreeNode()
		{
			Class13.xnk8ImWzpOt04();
			this.<Children>k__BackingField = new List<SimpleTreeNode>();
			base..ctor();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
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
