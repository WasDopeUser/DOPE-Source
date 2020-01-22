using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DOPE.Common.Models.Bot.Stats
{
	public class BindingValue<T, TSource> : IDisposable, IValueWrapper<T>, INotifyPropertyChanged where TSource : class, INotifyPropertyChanged
	{
		public void Bind(TSource obj)
		{
			if (this.Source != null)
			{
				this.Source.PropertyChanged -= this.Source_PropertyChanged;
			}
			this.Source = obj;
			if (obj != null)
			{
				obj.PropertyChanged += this.Source_PropertyChanged;
				this.Source_PropertyChanged(obj, null);
			}
		}

		public BindingValue(TSource source, Func<TSource, T> getter)
		{
			this.Getter = getter;
			this.Bind(source);
		}

		private void Source_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			T t = this.Getter(this.Source);
			if (!EqualityComparer<T>.Default.Equals(this.Value, t))
			{
				this.Value = t;
			}
		}

		public T Value
		{
			[CompilerGenerated]
			get
			{
				return this.<Value>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (object.Equals(this.<Value>k__BackingField, value))
				{
					return;
				}
				this.<Value>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Value);
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void Dispose()
		{
			this.Bind(default(TSource));
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

		public Func<TSource, T> Getter;

		public TSource Source;
	}
}
