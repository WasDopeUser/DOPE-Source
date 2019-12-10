using System;
using System.ComponentModel;

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
