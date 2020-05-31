using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace DOPE.Common.Models.Bot.Stats
{
	public class RowEntry : IDisposable, INotifyPropertyChanged, IRowEntry
	{
		public virtual string Key
		{
			[CompilerGenerated]
			get
			{
				return this.<Key>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (string.Equals(this.<Key>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Key>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Group);
				this.OnKeyChanged();
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_55);
			}
		}

		private void OnKeyChanged()
		{
			string key = this.Key;
			this.Group = StatisticsCategory.ExtractGroup(key);
		}

		public virtual IValueWrapper<string> First
		{
			[CompilerGenerated]
			get
			{
				return this.<First>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<First>k__BackingField, value))
				{
					return;
				}
				this.<First>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_29);
			}
		}

		public string Group
		{
			[CompilerGenerated]
			get
			{
				return this.<Group>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (string.Equals(this.<Group>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Group>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.Group);
			}
		}

		public int Order
		{
			[CompilerGenerated]
			get
			{
				return this.<Order>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (this.<Order>k__BackingField == value)
				{
					return;
				}
				this.<Order>k__BackingField = value;
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_69);
			}
		}

		IReadOnlyList<IValueWrapper<string>> IRowEntry.Cells
		{
			get
			{
				return this.Cells;
			}
		}

		public List<IValueWrapper<string>> Cells { get; }

		public RowEntry(string key, int order, params IValueWrapper<string>[] cells)
		{
			this.Key = key;
			this.Cells = new List<IValueWrapper<string>>(cells);
			this.Order = order;
		}

		public RowEntry(string key, params IValueWrapper<string>[] cells) : this(key, 0, cells)
		{
		}

		public virtual void ForEach(Action<IValueWrapper<string>> action)
		{
			foreach (IValueWrapper<string> obj in this.Cells)
			{
				if (action != null)
				{
					action(obj);
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (IValueWrapper<string> valueWrapper in this.Cells)
				{
					if (valueWrapper != null)
					{
						IDisposable disposable = valueWrapper as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
		}

		public void Dispose()
		{
			this.Dispose(true);
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
	}
}
