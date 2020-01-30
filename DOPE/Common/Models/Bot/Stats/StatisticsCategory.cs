using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ace.Networking.Extensions;

namespace DOPE.Common.Models.Bot.Stats
{
	public abstract class StatisticsCategory : INotifyPropertyChanged
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
				this.<>OnPropertyChanged(Class7.propertyChangedEventArgs_54);
			}
		}

		public IEnumerable<string> ColumnNames { get; }

		public ObservableCollection<IRowEntry> Items { get; }

		public StatisticsCategory(string key, IEnumerable<string> columns, params IRowEntry[] items)
		{
			this.Key = key;
			this.Items = new ObservableCollection<IRowEntry>(items ?? new IRowEntry[0]);
			this.ColumnNames = columns;
		}

		protected static VariableValue<string> V(string v)
		{
			return new VariableValue<string>(v);
		}

		protected static DelegateValue<string> F(Func<string> f)
		{
			return new DelegateValue<string>(f);
		}

		protected static BindingValue<string, T> B<T>(T source, Func<T, string> f) where T : class, INotifyPropertyChanged
		{
			return new BindingValue<string, T>(source, f);
		}

		protected LazyBindingValue<string, TSource> L<TSource>(Func<TSource, string> f) where TSource : class
		{
			return new LazyBindingValue<string, TSource>(f, null);
		}

		protected void Subscribe<T>(T obj) where T : class, INotifyPropertyChanged
		{
			Dictionary<Type, object> subscribed = this.Subscribed;
			lock (subscribed)
			{
				this.Subscribed[typeof(T)] = obj;
			}
			this.Obj_PropertyChanged(obj, null, typeof(T));
		}

		private void Obj_PropertyChanged(object sender, PropertyChangedEventArgs e, Type type)
		{
			Dictionary<Type, LinkedList<ILazyUpdatable>> lazyBindings = this.LazyBindings;
			lock (lazyBindings)
			{
				LinkedList<ILazyUpdatable> linkedList;
				if (this.LazyBindings.TryGetValue(type, out linkedList))
				{
					foreach (ILazyUpdatable lazyUpdatable in linkedList)
					{
						lazyUpdatable.Update(sender);
					}
				}
			}
		}

		public static string ExtractName(string key)
		{
			int num = key.IndexOf('_');
			if (num >= 0)
			{
				return key.Substring(num).TrimStart(new char[]
				{
					'_'
				});
			}
			return key;
		}

		public static string ExtractGroup(string key)
		{
			int num = key.IndexOf('_');
			if (num > 0)
			{
				return key.Substring(0, num);
			}
			return "General";
		}

		protected static RowEntry WithName(string key, params IValueWrapper<string>[] other)
		{
			IValueWrapper<string>[] array = new IValueWrapper<string>[other.Length + 1];
			array[0] = StatisticsCategory.V(StatisticsCategory.ExtractName(key));
			Array.Copy(other, 0, array, 1, other.Length);
			return new RowEntry(key, array);
		}

		public IRowEntry Get(string key)
		{
			ObservableCollection<IRowEntry> items = this.Items;
			IRowEntry result;
			lock (items)
			{
				foreach (IRowEntry rowEntry in this.Items)
				{
					if (rowEntry.Key == key)
					{
						return rowEntry;
					}
				}
				result = null;
			}
			return result;
		}

		public bool Remove(IRowEntry entry)
		{
			IRowEntry rowEntry = null;
			ObservableCollection<IRowEntry> items = this.Items;
			bool result;
			lock (items)
			{
				rowEntry = this.Get(entry.Key);
				if (rowEntry != null)
				{
					this.Items.Remove(rowEntry);
					goto IL_42;
				}
				result = false;
			}
			return result;
			IL_42:
			this._Remove(rowEntry);
			return true;
		}

		public bool Add(string key, Func<IRowEntry> factory)
		{
			ObservableCollection<IRowEntry> items = this.Items;
			bool result;
			lock (items)
			{
				IRowEntry rowEntry = this.Get(key);
				if (rowEntry != null)
				{
					result = false;
				}
				else
				{
					rowEntry = factory();
					this._Add(rowEntry);
					this.Items.Add(rowEntry);
					result = true;
				}
			}
			return result;
		}

		public IRowEntry GetOrAdd(string key, Func<IRowEntry> factory)
		{
			ObservableCollection<IRowEntry> items = this.Items;
			IRowEntry result;
			lock (items)
			{
				IRowEntry rowEntry = this.Get(key);
				if (rowEntry != null)
				{
					result = rowEntry;
				}
				else
				{
					rowEntry = factory();
					this._Add(rowEntry);
					this.Items.Add(rowEntry);
					result = rowEntry;
				}
			}
			return result;
		}

		protected void _Add(IRowEntry entry)
		{
			foreach (IValueWrapper<string> valueWrapper in entry.Cells)
			{
				ILazyUpdatable lazyUpdatable = valueWrapper as ILazyUpdatable;
				if (lazyUpdatable != null)
				{
					object source;
					if (this.Subscribed.TryGetValue(lazyUpdatable.GetSourceType(), out source))
					{
						lazyUpdatable.Update(source);
					}
					Dictionary<Type, LinkedList<ILazyUpdatable>> lazyBindings = this.LazyBindings;
					lock (lazyBindings)
					{
						this.LazyBindings.Append(lazyUpdatable.GetSourceType(), lazyUpdatable);
					}
				}
			}
		}

		public bool Add(IRowEntry entry)
		{
			ObservableCollection<IRowEntry> items = this.Items;
			bool result;
			lock (items)
			{
				if (this.Get(entry.Key) != null)
				{
					result = false;
				}
				else
				{
					this._Add(entry);
					this.Items.Add(entry);
					result = true;
				}
			}
			return result;
		}

		public void ScheduleClear()
		{
			this._clearRequested = true;
		}

		protected void _Remove(IRowEntry entry)
		{
			foreach (IValueWrapper<string> valueWrapper in entry.Cells)
			{
				ILazyUpdatable lazyUpdatable = valueWrapper as ILazyUpdatable;
				if (lazyUpdatable != null)
				{
					Dictionary<Type, LinkedList<ILazyUpdatable>> lazyBindings = this.LazyBindings;
					lock (lazyBindings)
					{
						this.LazyBindings[lazyUpdatable.GetSourceType()].Remove(lazyUpdatable);
					}
				}
			}
			IDisposable disposable = entry as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		protected virtual void Clear()
		{
			ObservableCollection<IRowEntry> items = this.Items;
			lock (items)
			{
				foreach (IRowEntry entry in this.Items)
				{
					this._Remove(entry);
				}
				this.Items.Clear();
			}
		}

		public virtual void Update()
		{
			if (this._clearRequested)
			{
				this._clearRequested = false;
				this.Clear();
			}
			foreach (KeyValuePair<Type, object> keyValuePair in this.Subscribed)
			{
				if (keyValuePair.Value != null)
				{
					this.Obj_PropertyChanged(keyValuePair.Value, null, keyValuePair.Key);
				}
			}
		}

		public virtual void Rebuild()
		{
			this.Clear();
			this.Update();
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

		protected readonly Dictionary<Type, LinkedList<ILazyUpdatable>> LazyBindings = new Dictionary<Type, LinkedList<ILazyUpdatable>>();

		protected readonly Dictionary<Type, object> Subscribed = new Dictionary<Type, object>();

		private bool _clearRequested;
	}
}
