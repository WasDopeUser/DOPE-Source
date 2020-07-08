using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

[CollectionDataContract(Namespace = "")]
public class GClass4<vnvLnhtKG25M2x2Pvd> : ICollection<vnvLnhtKG25M2x2Pvd>, IEnumerable<vnvLnhtKG25M2x2Pvd>, IReadOnlyList<vnvLnhtKG25M2x2Pvd>, IReadOnlyCollection<vnvLnhtKG25M2x2Pvd>, IEnumerable, ICollection
{
	[CompilerGenerated]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gdelegate = this.gdelegate0_0;
		GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GDelegate0 value = (GDelegate0)Delegate.Combine(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		GDelegate0 gdelegate = this.gdelegate0_0;
		GDelegate0 gdelegate2;
		do
		{
			gdelegate2 = gdelegate;
			GDelegate0 value = (GDelegate0)Delegate.Remove(gdelegate2, gdelegate0_1);
			gdelegate = Interlocked.CompareExchange<GDelegate0>(ref this.gdelegate0_0, value, gdelegate2);
		}
		while (gdelegate != gdelegate2);
	}

	[CompilerGenerated]
	public Dispatcher method_2()
	{
		return this.dispatcher_0;
	}

	[CompilerGenerated]
	public void method_3(Dispatcher dispatcher_1)
	{
		this.dispatcher_0 = dispatcher_1;
	}

	public ObservableCollection<vnvLnhtKG25M2x2Pvd> ObsColl
	{
		get
		{
			return this.observableCollection_0;
		}
	}

	public GClass4()
	{
		Class13.xnk8ImWzpOt04();
		this.list_0 = new List<vnvLnhtKG25M2x2Pvd>();
		this.list_1 = new List<vnvLnhtKG25M2x2Pvd>();
		this.object_0 = new object();
		this.list_2 = new List<vnvLnhtKG25M2x2Pvd>();
		this.observableCollection_0 = new ObservableCollection<vnvLnhtKG25M2x2Pvd>();
		this.jwgqqWyOs = new ConcurrentQueue<NotifyCollectionChangedEventArgs>();
		base..ctor();
		this.method_3(Application.Current.Dispatcher);
	}

	public bool method_4()
	{
		return this.bool_0;
	}

	public void method_5(bool bool_1)
	{
		this.bool_0 = bool_1;
	}

	public Tuple<List<vnvLnhtKG25M2x2Pvd>, List<vnvLnhtKG25M2x2Pvd>> method_6()
	{
		object obj = this.object_0;
		Tuple<List<vnvLnhtKG25M2x2Pvd>, List<vnvLnhtKG25M2x2Pvd>> result;
		lock (obj)
		{
			result = new Tuple<List<vnvLnhtKG25M2x2Pvd>, List<vnvLnhtKG25M2x2Pvd>>(this.list_0, this.list_1);
			this.list_0 = new List<vnvLnhtKG25M2x2Pvd>();
			this.list_1 = new List<vnvLnhtKG25M2x2Pvd>();
		}
		return result;
	}

	public vnvLnhtKG25M2x2Pvd[] method_7()
	{
		object obj = this.object_0;
		vnvLnhtKG25M2x2Pvd[] result;
		lock (obj)
		{
			result = this.list_0.ToArray();
		}
		return result;
	}

	public vnvLnhtKG25M2x2Pvd[] method_8()
	{
		object obj = this.object_0;
		vnvLnhtKG25M2x2Pvd[] result;
		lock (obj)
		{
			result = this.list_1.ToArray();
		}
		return result;
	}

	private void method_9(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		this.jwgqqWyOs.Enqueue(notifyCollectionChangedEventArgs_0);
		this.method_2().BeginInvoke(new Action(this.method_10), Array.Empty<object>());
	}

	private void method_10()
	{
		if (!this.method_2().CheckAccess())
		{
			throw new Exception("Can't be called from any thread than the dispatcher one");
		}
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs;
		while (this.jwgqqWyOs.TryDequeue(out notifyCollectionChangedEventArgs))
		{
			switch (notifyCollectionChangedEventArgs.Action)
			{
			case NotifyCollectionChangedAction.Add:
			{
				int num = 0;
				using (IEnumerator enumerator = notifyCollectionChangedEventArgs.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						vnvLnhtKG25M2x2Pvd item = (vnvLnhtKG25M2x2Pvd)((object)obj);
						this.ObsColl.Insert(notifyCollectionChangedEventArgs.NewStartingIndex + num, item);
						num++;
					}
					continue;
				}
				break;
			}
			case NotifyCollectionChangedAction.Remove:
				break;
			case NotifyCollectionChangedAction.Replace:
				goto IL_10B;
			case NotifyCollectionChangedAction.Move:
				this.ObsColl.Move(notifyCollectionChangedEventArgs.OldStartingIndex, notifyCollectionChangedEventArgs.NewStartingIndex);
				continue;
			case NotifyCollectionChangedAction.Reset:
				this.ObsColl.Clear();
				continue;
			default:
				throw new Exception("Unsupported NotifyCollectionChangedEventArgs.Action");
			}
			if (notifyCollectionChangedEventArgs.NewStartingIndex >= 0)
			{
				this.ObsColl.RemoveAt(notifyCollectionChangedEventArgs.NewStartingIndex);
				continue;
			}
			using (IEnumerator enumerator = notifyCollectionChangedEventArgs.OldItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					vnvLnhtKG25M2x2Pvd item2 = (vnvLnhtKG25M2x2Pvd)((object)obj2);
					this.ObsColl.Remove(item2);
				}
				continue;
			}
			IL_10B:
			if (notifyCollectionChangedEventArgs.NewStartingIndex >= 0 && notifyCollectionChangedEventArgs.OldStartingIndex < 0)
			{
				throw new ArgumentException(string.Format("Replace action expect NewStartingIndex and OldStartingIndex as: 0 <= {0} <= {1}, {2} <= 0.", notifyCollectionChangedEventArgs.NewStartingIndex, this.ObsColl.Count, notifyCollectionChangedEventArgs.OldStartingIndex));
			}
			bool oldItems = notifyCollectionChangedEventArgs.OldItems != null;
			IList newItems = notifyCollectionChangedEventArgs.NewItems;
			if (!oldItems || newItems == null)
			{
				throw new ArgumentException("Both argument Old and New item should be IList in a replace action.");
			}
			this.ObsColl[notifyCollectionChangedEventArgs.NewStartingIndex] = (vnvLnhtKG25M2x2Pvd)((object)newItems[0]);
		}
	}

	public List<vnvLnhtKG25M2x2Pvd> method_11()
	{
		List<vnvLnhtKG25M2x2Pvd> result = null;
		object obj = this.object_0;
		lock (obj)
		{
			result = new List<vnvLnhtKG25M2x2Pvd>(this.list_2);
		}
		return result;
	}

	public void method_12(IList ilist_0)
	{
		GClass4<vnvLnhtKG25M2x2Pvd>.<>c__DisplayClass26_0 CS$<>8__locals1 = new GClass4<vnvLnhtKG25M2x2Pvd>.<>c__DisplayClass26_0();
		CS$<>8__locals1.list = ilist_0;
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.smethod_3(new Action<vnvLnhtKG25M2x2Pvd>(CS$<>8__locals1.method_0));
		}
	}

	public virtual IEnumerator<vnvLnhtKG25M2x2Pvd> GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public virtual IEnumerator<vnvLnhtKG25M2x2Pvd> GetBlockingEnumerator()
	{
		return new GClass1<vnvLnhtKG25M2x2Pvd>(this.list_2.GetEnumerator(), this.object_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.method_11().GetEnumerator();
	}

	public void method_13(vnvLnhtKG25M2x2Pvd oBY1E168A5ukiw02WT)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Insert(0, oBY1E168A5ukiw02WT);
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, oBY1E168A5ukiw02WT, 0);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void Add(vnvLnhtKG25M2x2Pvd AwyJfLU7lJHT8j0wAR)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			this.list_2.Add(AwyJfLU7lJHT8j0wAR);
			if (this.bool_0)
			{
				this.list_0.Add(AwyJfLU7lJHT8j0wAR);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, AwyJfLU7lJHT8j0wAR, this.list_2.Count - 1);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public void method_14(IList<vnvLnhtKG25M2x2Pvd> ilist_0)
	{
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			int count = this.list_2.Count;
			this.list_2.AddRange(ilist_0);
			if (this.bool_0)
			{
				this.list_0.AddRange(ilist_0);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, ilist_0 as IList, count);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public bool method_15(vnvLnhtKG25M2x2Pvd OdtdT8hVBqO3hALdN3)
	{
		bool result = false;
		object obj = this.object_0;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_;
		lock (obj)
		{
			result = this.list_2.Remove(OdtdT8hVBqO3hALdN3);
			if (this.bool_0)
			{
				this.list_0.Add(OdtdT8hVBqO3hALdN3);
			}
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, OdtdT8hVBqO3hALdN3);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
		return result;
	}

	public void method_16(vnvLnhtKG25M2x2Pvd oTasWr3t5aDLWtrVqA, vnvLnhtKG25M2x2Pvd SJKAlNdoREorLaQCWi)
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			int num = this.list_2.IndexOf(oTasWr3t5aDLWtrVqA);
			if (num < 0 || num >= this.list_2.Count)
			{
				throw new ArgumentException("Invalid old value");
			}
			if (this.bool_0)
			{
				this.list_0.Add(SJKAlNdoREorLaQCWi);
				this.list_1.Add(oTasWr3t5aDLWtrVqA);
			}
			this.list_2[num] = SJKAlNdoREorLaQCWi;
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, SJKAlNdoREorLaQCWi, oTasWr3t5aDLWtrVqA, num);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	private void method_17(NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_0)
	{
		if (this.gdelegate0_0 != null && notifyCollectionChangedEventArgs_0 != null)
		{
			this.gdelegate0_0(this, notifyCollectionChangedEventArgs_0);
		}
	}

	public vnvLnhtKG25M2x2Pvd method_18(int int_0)
	{
		return this.list_2[int_0];
	}

	public vnvLnhtKG25M2x2Pvd method_19(int int_0, vnvLnhtKG25M2x2Pvd PadZD3j1DyXLmCAxcT)
	{
		vnvLnhtKG25M2x2Pvd vnvLnhtKG25M2x2Pvd = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_0.Add(PadZD3j1DyXLmCAxcT);
			this.list_1.Add(vnvLnhtKG25M2x2Pvd);
		}
		this.list_2[int_0] = PadZD3j1DyXLmCAxcT;
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, PadZD3j1DyXLmCAxcT, vnvLnhtKG25M2x2Pvd, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return vnvLnhtKG25M2x2Pvd;
	}

	public void method_20(int int_0, vnvLnhtKG25M2x2Pvd GikhiSr5cgqLoueSYd)
	{
		if (this.bool_0)
		{
			this.list_0.Add(GikhiSr5cgqLoueSYd);
		}
		this.list_2.Insert(int_0, GikhiSr5cgqLoueSYd);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, GikhiSr5cgqLoueSYd, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public vnvLnhtKG25M2x2Pvd method_21(int int_0)
	{
		vnvLnhtKG25M2x2Pvd vnvLnhtKG25M2x2Pvd = this.list_2[int_0];
		if (this.bool_0)
		{
			this.list_1.Add(vnvLnhtKG25M2x2Pvd);
		}
		this.list_2.RemoveAt(int_0);
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, vnvLnhtKG25M2x2Pvd, int_0);
		this.method_9(notifyCollectionChangedEventArgs_);
		this.method_17(notifyCollectionChangedEventArgs_);
		return vnvLnhtKG25M2x2Pvd;
	}

	public virtual void Clear()
	{
		NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs_ = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.bool_0)
			{
				this.list_1.AddRange(this.list_2);
			}
			this.list_2.Clear();
			notifyCollectionChangedEventArgs_ = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
			this.method_9(notifyCollectionChangedEventArgs_);
		}
		this.method_17(notifyCollectionChangedEventArgs_);
	}

	public bool Contains(vnvLnhtKG25M2x2Pvd y41OAr7MPUOykYjmRy)
	{
		object obj = this.object_0;
		bool result;
		lock (obj)
		{
			result = this.list_2.Contains(y41OAr7MPUOykYjmRy);
		}
		return result;
	}

	public void CopyTo(vnvLnhtKG25M2x2Pvd[] array, int arrayIndex)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.list_2.CopyTo(array, arrayIndex);
		}
	}

	public int Count
	{
		get
		{
			object obj = this.object_0;
			int count;
			lock (obj)
			{
				count = this.list_2.Count;
			}
			return count;
		}
	}

	public void method_22(object object_1)
	{
		this.method_15((vnvLnhtKG25M2x2Pvd)((object)object_1));
	}

	public int method_23(object object_1)
	{
		return this.method_23((vnvLnhtKG25M2x2Pvd)((object)object_1));
	}

	public object SyncRoot
	{
		get
		{
			return this.object_0;
		}
	}

	public bool method_24(IEnumerable<vnvLnhtKG25M2x2Pvd> ienumerable_0)
	{
		if (this.Count != ienumerable_0.Count<vnvLnhtKG25M2x2Pvd>())
		{
			return false;
		}
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator<vnvLnhtKG25M2x2Pvd> enumerator = this.GetEnumerator();
			enumerator.Reset();
			foreach (vnvLnhtKG25M2x2Pvd vnvLnhtKG25M2x2Pvd in ienumerable_0)
			{
				enumerator.MoveNext();
				vnvLnhtKG25M2x2Pvd vnvLnhtKG25M2x2Pvd2 = enumerator.Current;
				if (vnvLnhtKG25M2x2Pvd2.Equals(vnvLnhtKG25M2x2Pvd))
				{
					return false;
				}
			}
			GClass2.smethod_0(enumerator);
		}
		return true;
	}

	private void method_25()
	{
		if (!this.method_24(this.ObsColl))
		{
			this.method_26();
		}
	}

	private void method_26()
	{
		object obj = this.object_0;
		lock (obj)
		{
			IEnumerator enumerator = this.list_2.GetEnumerator();
			IEnumerator enumerator2 = this.ObsColl.GetEnumerator();
			enumerator.Reset();
			enumerator2.Reset();
			bool flag2 = enumerator.MoveNext();
			bool flag3 = enumerator2.MoveNext();
			while (flag2 || flag3)
			{
				if (flag2)
				{
					flag2 = enumerator.MoveNext();
				}
				if (flag3)
				{
					flag3 = enumerator2.MoveNext();
				}
			}
			GClass2.smethod_0(enumerator);
			GClass2.smethod_0(enumerator2);
		}
	}

	[OnSerializing]
	private void method_27(StreamingContext streamingContext_0)
	{
		Monitor.Enter(this.object_0);
	}

	[OnSerialized]
	private void method_28(StreamingContext streamingContext_0)
	{
		Monitor.Exit(this.object_0);
	}

	[OnDeserializing]
	private void method_29(StreamingContext streamingContext_0)
	{
	}

	[OnDeserialized]
	private void method_30(StreamingContext streamingContext_0)
	{
	}

	public vnvLnhtKG25M2x2Pvd this[int index]
	{
		get
		{
			return this.list_2[index];
		}
	}

	public void method_31(vnvLnhtKG25M2x2Pvd PbbLs0gyPAiLZt7k8J)
	{
		this.Add(PbbLs0gyPAiLZt7k8J);
	}

	public bool method_32(out vnvLnhtKG25M2x2Pvd gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			int count = this.list_2.Count;
			if (count > 0)
			{
				gparam_0 = this.method_21(count - 1);
				return true;
			}
		}
		gparam_0 = default(vnvLnhtKG25M2x2Pvd);
		return false;
	}

	public void method_33(vnvLnhtKG25M2x2Pvd TobmCFMXaMfuqNwMan)
	{
		this.Add(TobmCFMXaMfuqNwMan);
	}

	public bool method_34(out vnvLnhtKG25M2x2Pvd gparam_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			if (this.list_2.Count > 0)
			{
				gparam_0 = this.method_21(0);
				return true;
			}
		}
		gparam_0 = default(vnvLnhtKG25M2x2Pvd);
		return false;
	}

	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	bool ICollection<vnvLnhtKG25M2x2Pvd>.Remove(vnvLnhtKG25M2x2Pvd wyRo6921voYLXVpGOk)
	{
		return this.method_15(wyRo6921voYLXVpGOk);
	}

	public void CopyTo(Array array, int index)
	{
		object obj = this.object_0;
		lock (obj)
		{
			foreach (vnvLnhtKG25M2x2Pvd vnvLnhtKG25M2x2Pvd in this.list_2)
			{
				array.SetValue(vnvLnhtKG25M2x2Pvd, index++);
			}
		}
	}

	public bool IsSynchronized
	{
		get
		{
			return this.method_2().CheckAccess();
		}
	}

	private List<vnvLnhtKG25M2x2Pvd> list_0;

	private List<vnvLnhtKG25M2x2Pvd> list_1;

	private bool bool_0;

	private readonly object object_0;

	protected List<vnvLnhtKG25M2x2Pvd> list_2;

	private readonly ObservableCollection<vnvLnhtKG25M2x2Pvd> observableCollection_0;

	private readonly ConcurrentQueue<NotifyCollectionChangedEventArgs> jwgqqWyOs;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	[CompilerGenerated]
	private Dispatcher dispatcher_0;
}
