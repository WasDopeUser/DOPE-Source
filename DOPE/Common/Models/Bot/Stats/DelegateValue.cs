using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace DOPE.Common.Models.Bot.Stats
{
	public class DelegateValue<T> : IValueWrapper<T>, INotifyPropertyChanged
	{
		public DelegateValue(Func<T> getter)
		{
			this.Getter = getter;
		}

		public T Value
		{
			get
			{
				return this.Getter();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[DebuggerNonUserCode]
		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		protected void <>OnPropertyChanged(PropertyChangedEventArgs eventArgs)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, eventArgs);
			}
		}

		public Func<T> Getter;
	}
}
