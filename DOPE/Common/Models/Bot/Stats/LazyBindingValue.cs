using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DOPE.Common.Models.Bot.Stats
{
	public class LazyBindingValue<T, TSource> : IDisposable, IValueWrapper<T>, INotifyPropertyChanged, ILazyUpdatable where TSource : class
	{
		public T Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (object.Equals(this.<Value>k__BackingField, value))
				{
					return;
				}
				this.<Value>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Value);
			}
		}

		public LazyBindingValue(Func<TSource, T> getter, T fallback = default(T))
		{
			this._getter = getter;
			this.Value = fallback;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Dispose()
		{
			this.PropertyChanged = null;
			this._getter = null;
			this.Value = default(T);
		}

		public void Update(object source)
		{
			if (this._getter != null)
			{
				this.Value = this._getter(source as TSource);
			}
		}

		public Type GetSourceType()
		{
			return typeof(TSource);
		}

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

		private Func<TSource, T> _getter;
	}
}
