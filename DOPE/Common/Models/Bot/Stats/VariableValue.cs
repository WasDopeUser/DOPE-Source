using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DOPE.Common.Models.Bot.Stats
{
	public class VariableValue<T> : IValueWrapper<T>, INotifyPropertyChanged
	{
		public T Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Value>k__BackingField, value))
				{
					return;
				}
				this.<Value>k__BackingField = value;
				this.<>OnPropertyChanged(Class3.Value);
			}
		}

		public VariableValue()
		{
		}

		public VariableValue(T value)
		{
			this.Value = value;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}
	}
}
